#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.KcqLoaiKhoiLuongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqLoaiKhoiLuongDataSourceDesigner))]
	public class KcqLoaiKhoiLuongDataSource : ProviderDataSource<KcqLoaiKhoiLuong, KcqLoaiKhoiLuongKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqLoaiKhoiLuongDataSource class.
		/// </summary>
		public KcqLoaiKhoiLuongDataSource() : base(new KcqLoaiKhoiLuongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqLoaiKhoiLuongDataSourceView used by the KcqLoaiKhoiLuongDataSource.
		/// </summary>
		protected KcqLoaiKhoiLuongDataSourceView KcqLoaiKhoiLuongView
		{
			get { return ( View as KcqLoaiKhoiLuongDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqLoaiKhoiLuongDataSource control invokes to retrieve data.
		/// </summary>
		public KcqLoaiKhoiLuongSelectMethod SelectMethod
		{
			get
			{
				KcqLoaiKhoiLuongSelectMethod selectMethod = KcqLoaiKhoiLuongSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqLoaiKhoiLuongSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqLoaiKhoiLuongDataSourceView class that is to be
		/// used by the KcqLoaiKhoiLuongDataSource.
		/// </summary>
		/// <returns>An instance of the KcqLoaiKhoiLuongDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqLoaiKhoiLuong, KcqLoaiKhoiLuongKey> GetNewDataSourceView()
		{
			return new KcqLoaiKhoiLuongDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the KcqLoaiKhoiLuongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqLoaiKhoiLuongDataSourceView : ProviderDataSourceView<KcqLoaiKhoiLuong, KcqLoaiKhoiLuongKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqLoaiKhoiLuongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqLoaiKhoiLuongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqLoaiKhoiLuongDataSourceView(KcqLoaiKhoiLuongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqLoaiKhoiLuongDataSource KcqLoaiKhoiLuongOwner
		{
			get { return Owner as KcqLoaiKhoiLuongDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqLoaiKhoiLuongSelectMethod SelectMethod
		{
			get { return KcqLoaiKhoiLuongOwner.SelectMethod; }
			set { KcqLoaiKhoiLuongOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqLoaiKhoiLuongService KcqLoaiKhoiLuongProvider
		{
			get { return Provider as KcqLoaiKhoiLuongService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqLoaiKhoiLuong> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqLoaiKhoiLuong> results = null;
			KcqLoaiKhoiLuong item;
			count = 0;
			
			System.String _maLoaiKhoiLuong;
			System.Int32? _maNhom_nullable;

			switch ( SelectMethod )
			{
				case KcqLoaiKhoiLuongSelectMethod.Get:
					KcqLoaiKhoiLuongKey entityKey  = new KcqLoaiKhoiLuongKey();
					entityKey.Load(values);
					item = KcqLoaiKhoiLuongProvider.Get(entityKey);
					results = new TList<KcqLoaiKhoiLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqLoaiKhoiLuongSelectMethod.GetAll:
                    results = KcqLoaiKhoiLuongProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqLoaiKhoiLuongSelectMethod.GetPaged:
					results = KcqLoaiKhoiLuongProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqLoaiKhoiLuongSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqLoaiKhoiLuongProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqLoaiKhoiLuongProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqLoaiKhoiLuongSelectMethod.GetByMaLoaiKhoiLuong:
					_maLoaiKhoiLuong = ( values["MaLoaiKhoiLuong"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLoaiKhoiLuong"], typeof(System.String)) : string.Empty;
					item = KcqLoaiKhoiLuongProvider.GetByMaLoaiKhoiLuong(_maLoaiKhoiLuong);
					results = new TList<KcqLoaiKhoiLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case KcqLoaiKhoiLuongSelectMethod.GetByMaNhom:
					_maNhom_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaNhom"], typeof(System.Int32?));
					results = KcqLoaiKhoiLuongProvider.GetByMaNhom(_maNhom_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == KcqLoaiKhoiLuongSelectMethod.Get || SelectMethod == KcqLoaiKhoiLuongSelectMethod.GetByMaLoaiKhoiLuong )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				KcqLoaiKhoiLuong entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqLoaiKhoiLuongProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<KcqLoaiKhoiLuong> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqLoaiKhoiLuongProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqLoaiKhoiLuongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqLoaiKhoiLuongDataSource class.
	/// </summary>
	public class KcqLoaiKhoiLuongDataSourceDesigner : ProviderDataSourceDesigner<KcqLoaiKhoiLuong, KcqLoaiKhoiLuongKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqLoaiKhoiLuongDataSourceDesigner class.
		/// </summary>
		public KcqLoaiKhoiLuongDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqLoaiKhoiLuongSelectMethod SelectMethod
		{
			get { return ((KcqLoaiKhoiLuongDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new KcqLoaiKhoiLuongDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqLoaiKhoiLuongDataSourceActionList

	/// <summary>
	/// Supports the KcqLoaiKhoiLuongDataSourceDesigner class.
	/// </summary>
	internal class KcqLoaiKhoiLuongDataSourceActionList : DesignerActionList
	{
		private KcqLoaiKhoiLuongDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqLoaiKhoiLuongDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqLoaiKhoiLuongDataSourceActionList(KcqLoaiKhoiLuongDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqLoaiKhoiLuongSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion KcqLoaiKhoiLuongDataSourceActionList
	
	#endregion KcqLoaiKhoiLuongDataSourceDesigner
	
	#region KcqLoaiKhoiLuongSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqLoaiKhoiLuongDataSource.SelectMethod property.
	/// </summary>
	public enum KcqLoaiKhoiLuongSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByMaLoaiKhoiLuong method.
		/// </summary>
		GetByMaLoaiKhoiLuong,
		/// <summary>
		/// Represents the GetByMaNhom method.
		/// </summary>
		GetByMaNhom
	}
	
	#endregion KcqLoaiKhoiLuongSelectMethod

	#region KcqLoaiKhoiLuongFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqLoaiKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqLoaiKhoiLuongFilter : SqlFilter<KcqLoaiKhoiLuongColumn>
	{
	}
	
	#endregion KcqLoaiKhoiLuongFilter

	#region KcqLoaiKhoiLuongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqLoaiKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqLoaiKhoiLuongExpressionBuilder : SqlExpressionBuilder<KcqLoaiKhoiLuongColumn>
	{
	}
	
	#endregion KcqLoaiKhoiLuongExpressionBuilder	

	#region KcqLoaiKhoiLuongProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqLoaiKhoiLuongChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqLoaiKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqLoaiKhoiLuongProperty : ChildEntityProperty<KcqLoaiKhoiLuongChildEntityTypes>
	{
	}
	
	#endregion KcqLoaiKhoiLuongProperty
}

