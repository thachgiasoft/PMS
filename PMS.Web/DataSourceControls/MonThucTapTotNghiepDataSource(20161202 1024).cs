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
	/// Represents the DataRepository.MonThucTapTotNghiepProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(MonThucTapTotNghiepDataSourceDesigner))]
	public class MonThucTapTotNghiepDataSource : ProviderDataSource<MonThucTapTotNghiep, MonThucTapTotNghiepKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonThucTapTotNghiepDataSource class.
		/// </summary>
		public MonThucTapTotNghiepDataSource() : base(new MonThucTapTotNghiepService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the MonThucTapTotNghiepDataSourceView used by the MonThucTapTotNghiepDataSource.
		/// </summary>
		protected MonThucTapTotNghiepDataSourceView MonThucTapTotNghiepView
		{
			get { return ( View as MonThucTapTotNghiepDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the MonThucTapTotNghiepDataSource control invokes to retrieve data.
		/// </summary>
		public MonThucTapTotNghiepSelectMethod SelectMethod
		{
			get
			{
				MonThucTapTotNghiepSelectMethod selectMethod = MonThucTapTotNghiepSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (MonThucTapTotNghiepSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the MonThucTapTotNghiepDataSourceView class that is to be
		/// used by the MonThucTapTotNghiepDataSource.
		/// </summary>
		/// <returns>An instance of the MonThucTapTotNghiepDataSourceView class.</returns>
		protected override BaseDataSourceView<MonThucTapTotNghiep, MonThucTapTotNghiepKey> GetNewDataSourceView()
		{
			return new MonThucTapTotNghiepDataSourceView(this, DefaultViewName);
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
	/// Supports the MonThucTapTotNghiepDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class MonThucTapTotNghiepDataSourceView : ProviderDataSourceView<MonThucTapTotNghiep, MonThucTapTotNghiepKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonThucTapTotNghiepDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the MonThucTapTotNghiepDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public MonThucTapTotNghiepDataSourceView(MonThucTapTotNghiepDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal MonThucTapTotNghiepDataSource MonThucTapTotNghiepOwner
		{
			get { return Owner as MonThucTapTotNghiepDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal MonThucTapTotNghiepSelectMethod SelectMethod
		{
			get { return MonThucTapTotNghiepOwner.SelectMethod; }
			set { MonThucTapTotNghiepOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal MonThucTapTotNghiepService MonThucTapTotNghiepProvider
		{
			get { return Provider as MonThucTapTotNghiepService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<MonThucTapTotNghiep> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<MonThucTapTotNghiep> results = null;
			MonThucTapTotNghiep item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2765_NamHoc;
			System.String sp2765_HocKy;

			switch ( SelectMethod )
			{
				case MonThucTapTotNghiepSelectMethod.Get:
					MonThucTapTotNghiepKey entityKey  = new MonThucTapTotNghiepKey();
					entityKey.Load(values);
					item = MonThucTapTotNghiepProvider.Get(entityKey);
					results = new TList<MonThucTapTotNghiep>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case MonThucTapTotNghiepSelectMethod.GetAll:
                    results = MonThucTapTotNghiepProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case MonThucTapTotNghiepSelectMethod.GetPaged:
					results = MonThucTapTotNghiepProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case MonThucTapTotNghiepSelectMethod.Find:
					if ( FilterParameters != null )
						results = MonThucTapTotNghiepProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = MonThucTapTotNghiepProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case MonThucTapTotNghiepSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = MonThucTapTotNghiepProvider.GetById(_id);
					results = new TList<MonThucTapTotNghiep>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case MonThucTapTotNghiepSelectMethod.GetByNamHocHocKy:
					sp2765_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2765_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = MonThucTapTotNghiepProvider.GetByNamHocHocKy(sp2765_NamHoc, sp2765_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == MonThucTapTotNghiepSelectMethod.Get || SelectMethod == MonThucTapTotNghiepSelectMethod.GetById )
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
				MonThucTapTotNghiep entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					MonThucTapTotNghiepProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<MonThucTapTotNghiep> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			MonThucTapTotNghiepProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region MonThucTapTotNghiepDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the MonThucTapTotNghiepDataSource class.
	/// </summary>
	public class MonThucTapTotNghiepDataSourceDesigner : ProviderDataSourceDesigner<MonThucTapTotNghiep, MonThucTapTotNghiepKey>
	{
		/// <summary>
		/// Initializes a new instance of the MonThucTapTotNghiepDataSourceDesigner class.
		/// </summary>
		public MonThucTapTotNghiepDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonThucTapTotNghiepSelectMethod SelectMethod
		{
			get { return ((MonThucTapTotNghiepDataSource) DataSource).SelectMethod; }
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
				actions.Add(new MonThucTapTotNghiepDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region MonThucTapTotNghiepDataSourceActionList

	/// <summary>
	/// Supports the MonThucTapTotNghiepDataSourceDesigner class.
	/// </summary>
	internal class MonThucTapTotNghiepDataSourceActionList : DesignerActionList
	{
		private MonThucTapTotNghiepDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the MonThucTapTotNghiepDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public MonThucTapTotNghiepDataSourceActionList(MonThucTapTotNghiepDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonThucTapTotNghiepSelectMethod SelectMethod
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

	#endregion MonThucTapTotNghiepDataSourceActionList
	
	#endregion MonThucTapTotNghiepDataSourceDesigner
	
	#region MonThucTapTotNghiepSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the MonThucTapTotNghiepDataSource.SelectMethod property.
	/// </summary>
	public enum MonThucTapTotNghiepSelectMethod
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
	
	#endregion MonThucTapTotNghiepSelectMethod

	#region MonThucTapTotNghiepFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonThucTapTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonThucTapTotNghiepFilter : SqlFilter<MonThucTapTotNghiepColumn>
	{
	}
	
	#endregion MonThucTapTotNghiepFilter

	#region MonThucTapTotNghiepExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonThucTapTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonThucTapTotNghiepExpressionBuilder : SqlExpressionBuilder<MonThucTapTotNghiepColumn>
	{
	}
	
	#endregion MonThucTapTotNghiepExpressionBuilder	

	#region MonThucTapTotNghiepProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;MonThucTapTotNghiepChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="MonThucTapTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonThucTapTotNghiepProperty : ChildEntityProperty<MonThucTapTotNghiepChildEntityTypes>
	{
	}
	
	#endregion MonThucTapTotNghiepProperty
}

