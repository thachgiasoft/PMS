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
	/// Represents the DataRepository.MonHocKhongTinhKhoiLuongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(MonHocKhongTinhKhoiLuongDataSourceDesigner))]
	public class MonHocKhongTinhKhoiLuongDataSource : ProviderDataSource<MonHocKhongTinhKhoiLuong, MonHocKhongTinhKhoiLuongKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonHocKhongTinhKhoiLuongDataSource class.
		/// </summary>
		public MonHocKhongTinhKhoiLuongDataSource() : base(new MonHocKhongTinhKhoiLuongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the MonHocKhongTinhKhoiLuongDataSourceView used by the MonHocKhongTinhKhoiLuongDataSource.
		/// </summary>
		protected MonHocKhongTinhKhoiLuongDataSourceView MonHocKhongTinhKhoiLuongView
		{
			get { return ( View as MonHocKhongTinhKhoiLuongDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the MonHocKhongTinhKhoiLuongDataSource control invokes to retrieve data.
		/// </summary>
		public MonHocKhongTinhKhoiLuongSelectMethod SelectMethod
		{
			get
			{
				MonHocKhongTinhKhoiLuongSelectMethod selectMethod = MonHocKhongTinhKhoiLuongSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (MonHocKhongTinhKhoiLuongSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the MonHocKhongTinhKhoiLuongDataSourceView class that is to be
		/// used by the MonHocKhongTinhKhoiLuongDataSource.
		/// </summary>
		/// <returns>An instance of the MonHocKhongTinhKhoiLuongDataSourceView class.</returns>
		protected override BaseDataSourceView<MonHocKhongTinhKhoiLuong, MonHocKhongTinhKhoiLuongKey> GetNewDataSourceView()
		{
			return new MonHocKhongTinhKhoiLuongDataSourceView(this, DefaultViewName);
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
	/// Supports the MonHocKhongTinhKhoiLuongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class MonHocKhongTinhKhoiLuongDataSourceView : ProviderDataSourceView<MonHocKhongTinhKhoiLuong, MonHocKhongTinhKhoiLuongKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonHocKhongTinhKhoiLuongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the MonHocKhongTinhKhoiLuongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public MonHocKhongTinhKhoiLuongDataSourceView(MonHocKhongTinhKhoiLuongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal MonHocKhongTinhKhoiLuongDataSource MonHocKhongTinhKhoiLuongOwner
		{
			get { return Owner as MonHocKhongTinhKhoiLuongDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal MonHocKhongTinhKhoiLuongSelectMethod SelectMethod
		{
			get { return MonHocKhongTinhKhoiLuongOwner.SelectMethod; }
			set { MonHocKhongTinhKhoiLuongOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal MonHocKhongTinhKhoiLuongService MonHocKhongTinhKhoiLuongProvider
		{
			get { return Provider as MonHocKhongTinhKhoiLuongService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<MonHocKhongTinhKhoiLuong> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<MonHocKhongTinhKhoiLuong> results = null;
			MonHocKhongTinhKhoiLuong item;
			count = 0;
			
			System.Int32 _id;
			System.String sp663_NamHoc;
			System.String sp663_HocKy;

			switch ( SelectMethod )
			{
				case MonHocKhongTinhKhoiLuongSelectMethod.Get:
					MonHocKhongTinhKhoiLuongKey entityKey  = new MonHocKhongTinhKhoiLuongKey();
					entityKey.Load(values);
					item = MonHocKhongTinhKhoiLuongProvider.Get(entityKey);
					results = new TList<MonHocKhongTinhKhoiLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case MonHocKhongTinhKhoiLuongSelectMethod.GetAll:
                    results = MonHocKhongTinhKhoiLuongProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case MonHocKhongTinhKhoiLuongSelectMethod.GetPaged:
					results = MonHocKhongTinhKhoiLuongProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case MonHocKhongTinhKhoiLuongSelectMethod.Find:
					if ( FilterParameters != null )
						results = MonHocKhongTinhKhoiLuongProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = MonHocKhongTinhKhoiLuongProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case MonHocKhongTinhKhoiLuongSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = MonHocKhongTinhKhoiLuongProvider.GetById(_id);
					results = new TList<MonHocKhongTinhKhoiLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case MonHocKhongTinhKhoiLuongSelectMethod.GetByNamHocHocKy:
					sp663_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp663_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = MonHocKhongTinhKhoiLuongProvider.GetByNamHocHocKy(sp663_NamHoc, sp663_HocKy, StartIndex, PageSize);
					break;
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
			if ( SelectMethod == MonHocKhongTinhKhoiLuongSelectMethod.Get || SelectMethod == MonHocKhongTinhKhoiLuongSelectMethod.GetById )
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
				MonHocKhongTinhKhoiLuong entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					MonHocKhongTinhKhoiLuongProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<MonHocKhongTinhKhoiLuong> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			MonHocKhongTinhKhoiLuongProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region MonHocKhongTinhKhoiLuongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the MonHocKhongTinhKhoiLuongDataSource class.
	/// </summary>
	public class MonHocKhongTinhKhoiLuongDataSourceDesigner : ProviderDataSourceDesigner<MonHocKhongTinhKhoiLuong, MonHocKhongTinhKhoiLuongKey>
	{
		/// <summary>
		/// Initializes a new instance of the MonHocKhongTinhKhoiLuongDataSourceDesigner class.
		/// </summary>
		public MonHocKhongTinhKhoiLuongDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonHocKhongTinhKhoiLuongSelectMethod SelectMethod
		{
			get { return ((MonHocKhongTinhKhoiLuongDataSource) DataSource).SelectMethod; }
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
				actions.Add(new MonHocKhongTinhKhoiLuongDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region MonHocKhongTinhKhoiLuongDataSourceActionList

	/// <summary>
	/// Supports the MonHocKhongTinhKhoiLuongDataSourceDesigner class.
	/// </summary>
	internal class MonHocKhongTinhKhoiLuongDataSourceActionList : DesignerActionList
	{
		private MonHocKhongTinhKhoiLuongDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the MonHocKhongTinhKhoiLuongDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public MonHocKhongTinhKhoiLuongDataSourceActionList(MonHocKhongTinhKhoiLuongDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonHocKhongTinhKhoiLuongSelectMethod SelectMethod
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

	#endregion MonHocKhongTinhKhoiLuongDataSourceActionList
	
	#endregion MonHocKhongTinhKhoiLuongDataSourceDesigner
	
	#region MonHocKhongTinhKhoiLuongSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the MonHocKhongTinhKhoiLuongDataSource.SelectMethod property.
	/// </summary>
	public enum MonHocKhongTinhKhoiLuongSelectMethod
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
		/// Represents the GetById method.
		/// </summary>
		GetById,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion MonHocKhongTinhKhoiLuongSelectMethod

	#region MonHocKhongTinhKhoiLuongFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonHocKhongTinhKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonHocKhongTinhKhoiLuongFilter : SqlFilter<MonHocKhongTinhKhoiLuongColumn>
	{
	}
	
	#endregion MonHocKhongTinhKhoiLuongFilter

	#region MonHocKhongTinhKhoiLuongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonHocKhongTinhKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonHocKhongTinhKhoiLuongExpressionBuilder : SqlExpressionBuilder<MonHocKhongTinhKhoiLuongColumn>
	{
	}
	
	#endregion MonHocKhongTinhKhoiLuongExpressionBuilder	

	#region MonHocKhongTinhKhoiLuongProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;MonHocKhongTinhKhoiLuongChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="MonHocKhongTinhKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonHocKhongTinhKhoiLuongProperty : ChildEntityProperty<MonHocKhongTinhKhoiLuongChildEntityTypes>
	{
	}
	
	#endregion MonHocKhongTinhKhoiLuongProperty
}

