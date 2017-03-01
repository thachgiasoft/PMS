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
	/// Represents the DataRepository.LoaiKhoiLuongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(LoaiKhoiLuongDataSourceDesigner))]
	public class LoaiKhoiLuongDataSource : ProviderDataSource<LoaiKhoiLuong, LoaiKhoiLuongKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiKhoiLuongDataSource class.
		/// </summary>
		public LoaiKhoiLuongDataSource() : base(new LoaiKhoiLuongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the LoaiKhoiLuongDataSourceView used by the LoaiKhoiLuongDataSource.
		/// </summary>
		protected LoaiKhoiLuongDataSourceView LoaiKhoiLuongView
		{
			get { return ( View as LoaiKhoiLuongDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the LoaiKhoiLuongDataSource control invokes to retrieve data.
		/// </summary>
		public LoaiKhoiLuongSelectMethod SelectMethod
		{
			get
			{
				LoaiKhoiLuongSelectMethod selectMethod = LoaiKhoiLuongSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (LoaiKhoiLuongSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the LoaiKhoiLuongDataSourceView class that is to be
		/// used by the LoaiKhoiLuongDataSource.
		/// </summary>
		/// <returns>An instance of the LoaiKhoiLuongDataSourceView class.</returns>
		protected override BaseDataSourceView<LoaiKhoiLuong, LoaiKhoiLuongKey> GetNewDataSourceView()
		{
			return new LoaiKhoiLuongDataSourceView(this, DefaultViewName);
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
	/// Supports the LoaiKhoiLuongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class LoaiKhoiLuongDataSourceView : ProviderDataSourceView<LoaiKhoiLuong, LoaiKhoiLuongKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiKhoiLuongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the LoaiKhoiLuongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public LoaiKhoiLuongDataSourceView(LoaiKhoiLuongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal LoaiKhoiLuongDataSource LoaiKhoiLuongOwner
		{
			get { return Owner as LoaiKhoiLuongDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal LoaiKhoiLuongSelectMethod SelectMethod
		{
			get { return LoaiKhoiLuongOwner.SelectMethod; }
			set { LoaiKhoiLuongOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal LoaiKhoiLuongService LoaiKhoiLuongProvider
		{
			get { return Provider as LoaiKhoiLuongService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<LoaiKhoiLuong> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<LoaiKhoiLuong> results = null;
			LoaiKhoiLuong item;
			count = 0;
			
			System.String _maLoaiKhoiLuong;
			System.Int32? _maNhom_nullable;

			switch ( SelectMethod )
			{
				case LoaiKhoiLuongSelectMethod.Get:
					LoaiKhoiLuongKey entityKey  = new LoaiKhoiLuongKey();
					entityKey.Load(values);
					item = LoaiKhoiLuongProvider.Get(entityKey);
					results = new TList<LoaiKhoiLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case LoaiKhoiLuongSelectMethod.GetAll:
                    results = LoaiKhoiLuongProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case LoaiKhoiLuongSelectMethod.GetPaged:
					results = LoaiKhoiLuongProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case LoaiKhoiLuongSelectMethod.Find:
					if ( FilterParameters != null )
						results = LoaiKhoiLuongProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = LoaiKhoiLuongProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case LoaiKhoiLuongSelectMethod.GetByMaLoaiKhoiLuong:
					_maLoaiKhoiLuong = ( values["MaLoaiKhoiLuong"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLoaiKhoiLuong"], typeof(System.String)) : string.Empty;
					item = LoaiKhoiLuongProvider.GetByMaLoaiKhoiLuong(_maLoaiKhoiLuong);
					results = new TList<LoaiKhoiLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case LoaiKhoiLuongSelectMethod.GetByMaNhom:
					_maNhom_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaNhom"], typeof(System.Int32?));
					results = LoaiKhoiLuongProvider.GetByMaNhom(_maNhom_nullable, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == LoaiKhoiLuongSelectMethod.Get || SelectMethod == LoaiKhoiLuongSelectMethod.GetByMaLoaiKhoiLuong )
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
				LoaiKhoiLuong entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					LoaiKhoiLuongProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<LoaiKhoiLuong> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			LoaiKhoiLuongProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region LoaiKhoiLuongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the LoaiKhoiLuongDataSource class.
	/// </summary>
	public class LoaiKhoiLuongDataSourceDesigner : ProviderDataSourceDesigner<LoaiKhoiLuong, LoaiKhoiLuongKey>
	{
		/// <summary>
		/// Initializes a new instance of the LoaiKhoiLuongDataSourceDesigner class.
		/// </summary>
		public LoaiKhoiLuongDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LoaiKhoiLuongSelectMethod SelectMethod
		{
			get { return ((LoaiKhoiLuongDataSource) DataSource).SelectMethod; }
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
				actions.Add(new LoaiKhoiLuongDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region LoaiKhoiLuongDataSourceActionList

	/// <summary>
	/// Supports the LoaiKhoiLuongDataSourceDesigner class.
	/// </summary>
	internal class LoaiKhoiLuongDataSourceActionList : DesignerActionList
	{
		private LoaiKhoiLuongDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the LoaiKhoiLuongDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public LoaiKhoiLuongDataSourceActionList(LoaiKhoiLuongDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LoaiKhoiLuongSelectMethod SelectMethod
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

	#endregion LoaiKhoiLuongDataSourceActionList
	
	#endregion LoaiKhoiLuongDataSourceDesigner
	
	#region LoaiKhoiLuongSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the LoaiKhoiLuongDataSource.SelectMethod property.
	/// </summary>
	public enum LoaiKhoiLuongSelectMethod
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
	
	#endregion LoaiKhoiLuongSelectMethod

	#region LoaiKhoiLuongFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiKhoiLuongFilter : SqlFilter<LoaiKhoiLuongColumn>
	{
	}
	
	#endregion LoaiKhoiLuongFilter

	#region LoaiKhoiLuongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiKhoiLuongExpressionBuilder : SqlExpressionBuilder<LoaiKhoiLuongColumn>
	{
	}
	
	#endregion LoaiKhoiLuongExpressionBuilder	

	#region LoaiKhoiLuongProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;LoaiKhoiLuongChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiKhoiLuongProperty : ChildEntityProperty<LoaiKhoiLuongChildEntityTypes>
	{
	}
	
	#endregion LoaiKhoiLuongProperty
}

