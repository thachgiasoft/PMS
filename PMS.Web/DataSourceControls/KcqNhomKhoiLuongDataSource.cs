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
	/// Represents the DataRepository.KcqNhomKhoiLuongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqNhomKhoiLuongDataSourceDesigner))]
	public class KcqNhomKhoiLuongDataSource : ProviderDataSource<KcqNhomKhoiLuong, KcqNhomKhoiLuongKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqNhomKhoiLuongDataSource class.
		/// </summary>
		public KcqNhomKhoiLuongDataSource() : base(new KcqNhomKhoiLuongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqNhomKhoiLuongDataSourceView used by the KcqNhomKhoiLuongDataSource.
		/// </summary>
		protected KcqNhomKhoiLuongDataSourceView KcqNhomKhoiLuongView
		{
			get { return ( View as KcqNhomKhoiLuongDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqNhomKhoiLuongDataSource control invokes to retrieve data.
		/// </summary>
		public KcqNhomKhoiLuongSelectMethod SelectMethod
		{
			get
			{
				KcqNhomKhoiLuongSelectMethod selectMethod = KcqNhomKhoiLuongSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqNhomKhoiLuongSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqNhomKhoiLuongDataSourceView class that is to be
		/// used by the KcqNhomKhoiLuongDataSource.
		/// </summary>
		/// <returns>An instance of the KcqNhomKhoiLuongDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqNhomKhoiLuong, KcqNhomKhoiLuongKey> GetNewDataSourceView()
		{
			return new KcqNhomKhoiLuongDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqNhomKhoiLuongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqNhomKhoiLuongDataSourceView : ProviderDataSourceView<KcqNhomKhoiLuong, KcqNhomKhoiLuongKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqNhomKhoiLuongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqNhomKhoiLuongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqNhomKhoiLuongDataSourceView(KcqNhomKhoiLuongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqNhomKhoiLuongDataSource KcqNhomKhoiLuongOwner
		{
			get { return Owner as KcqNhomKhoiLuongDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqNhomKhoiLuongSelectMethod SelectMethod
		{
			get { return KcqNhomKhoiLuongOwner.SelectMethod; }
			set { KcqNhomKhoiLuongOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqNhomKhoiLuongService KcqNhomKhoiLuongProvider
		{
			get { return Provider as KcqNhomKhoiLuongService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqNhomKhoiLuong> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqNhomKhoiLuong> results = null;
			KcqNhomKhoiLuong item;
			count = 0;
			
			System.Int32 _maNhom;

			switch ( SelectMethod )
			{
				case KcqNhomKhoiLuongSelectMethod.Get:
					KcqNhomKhoiLuongKey entityKey  = new KcqNhomKhoiLuongKey();
					entityKey.Load(values);
					item = KcqNhomKhoiLuongProvider.Get(entityKey);
					results = new TList<KcqNhomKhoiLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqNhomKhoiLuongSelectMethod.GetAll:
                    results = KcqNhomKhoiLuongProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqNhomKhoiLuongSelectMethod.GetPaged:
					results = KcqNhomKhoiLuongProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqNhomKhoiLuongSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqNhomKhoiLuongProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqNhomKhoiLuongProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqNhomKhoiLuongSelectMethod.GetByMaNhom:
					_maNhom = ( values["MaNhom"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaNhom"], typeof(System.Int32)) : (int)0;
					item = KcqNhomKhoiLuongProvider.GetByMaNhom(_maNhom);
					results = new TList<KcqNhomKhoiLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
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
			if ( SelectMethod == KcqNhomKhoiLuongSelectMethod.Get || SelectMethod == KcqNhomKhoiLuongSelectMethod.GetByMaNhom )
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
				KcqNhomKhoiLuong entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqNhomKhoiLuongProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqNhomKhoiLuong> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqNhomKhoiLuongProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqNhomKhoiLuongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqNhomKhoiLuongDataSource class.
	/// </summary>
	public class KcqNhomKhoiLuongDataSourceDesigner : ProviderDataSourceDesigner<KcqNhomKhoiLuong, KcqNhomKhoiLuongKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqNhomKhoiLuongDataSourceDesigner class.
		/// </summary>
		public KcqNhomKhoiLuongDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqNhomKhoiLuongSelectMethod SelectMethod
		{
			get { return ((KcqNhomKhoiLuongDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqNhomKhoiLuongDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqNhomKhoiLuongDataSourceActionList

	/// <summary>
	/// Supports the KcqNhomKhoiLuongDataSourceDesigner class.
	/// </summary>
	internal class KcqNhomKhoiLuongDataSourceActionList : DesignerActionList
	{
		private KcqNhomKhoiLuongDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqNhomKhoiLuongDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqNhomKhoiLuongDataSourceActionList(KcqNhomKhoiLuongDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqNhomKhoiLuongSelectMethod SelectMethod
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

	#endregion KcqNhomKhoiLuongDataSourceActionList
	
	#endregion KcqNhomKhoiLuongDataSourceDesigner
	
	#region KcqNhomKhoiLuongSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqNhomKhoiLuongDataSource.SelectMethod property.
	/// </summary>
	public enum KcqNhomKhoiLuongSelectMethod
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
		/// Represents the GetByMaNhom method.
		/// </summary>
		GetByMaNhom
	}
	
	#endregion KcqNhomKhoiLuongSelectMethod

	#region KcqNhomKhoiLuongFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqNhomKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqNhomKhoiLuongFilter : SqlFilter<KcqNhomKhoiLuongColumn>
	{
	}
	
	#endregion KcqNhomKhoiLuongFilter

	#region KcqNhomKhoiLuongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqNhomKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqNhomKhoiLuongExpressionBuilder : SqlExpressionBuilder<KcqNhomKhoiLuongColumn>
	{
	}
	
	#endregion KcqNhomKhoiLuongExpressionBuilder	

	#region KcqNhomKhoiLuongProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqNhomKhoiLuongChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqNhomKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqNhomKhoiLuongProperty : ChildEntityProperty<KcqNhomKhoiLuongChildEntityTypes>
	{
	}
	
	#endregion KcqNhomKhoiLuongProperty
}

