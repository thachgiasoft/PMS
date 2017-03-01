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
	/// Represents the DataRepository.GiangDaySauDaiHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangDaySauDaiHocDataSourceDesigner))]
	public class GiangDaySauDaiHocDataSource : ProviderDataSource<GiangDaySauDaiHoc, GiangDaySauDaiHocKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangDaySauDaiHocDataSource class.
		/// </summary>
		public GiangDaySauDaiHocDataSource() : base(new GiangDaySauDaiHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangDaySauDaiHocDataSourceView used by the GiangDaySauDaiHocDataSource.
		/// </summary>
		protected GiangDaySauDaiHocDataSourceView GiangDaySauDaiHocView
		{
			get { return ( View as GiangDaySauDaiHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangDaySauDaiHocDataSource control invokes to retrieve data.
		/// </summary>
		public GiangDaySauDaiHocSelectMethod SelectMethod
		{
			get
			{
				GiangDaySauDaiHocSelectMethod selectMethod = GiangDaySauDaiHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangDaySauDaiHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangDaySauDaiHocDataSourceView class that is to be
		/// used by the GiangDaySauDaiHocDataSource.
		/// </summary>
		/// <returns>An instance of the GiangDaySauDaiHocDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangDaySauDaiHoc, GiangDaySauDaiHocKey> GetNewDataSourceView()
		{
			return new GiangDaySauDaiHocDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangDaySauDaiHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangDaySauDaiHocDataSourceView : ProviderDataSourceView<GiangDaySauDaiHoc, GiangDaySauDaiHocKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangDaySauDaiHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangDaySauDaiHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangDaySauDaiHocDataSourceView(GiangDaySauDaiHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangDaySauDaiHocDataSource GiangDaySauDaiHocOwner
		{
			get { return Owner as GiangDaySauDaiHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangDaySauDaiHocSelectMethod SelectMethod
		{
			get { return GiangDaySauDaiHocOwner.SelectMethod; }
			set { GiangDaySauDaiHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangDaySauDaiHocService GiangDaySauDaiHocProvider
		{
			get { return Provider as GiangDaySauDaiHocService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangDaySauDaiHoc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangDaySauDaiHoc> results = null;
			GiangDaySauDaiHoc item;
			count = 0;
			
			System.Int32 _id;
			System.String sp114_NamHoc;
			System.String sp114_HocKy;

			switch ( SelectMethod )
			{
				case GiangDaySauDaiHocSelectMethod.Get:
					GiangDaySauDaiHocKey entityKey  = new GiangDaySauDaiHocKey();
					entityKey.Load(values);
					item = GiangDaySauDaiHocProvider.Get(entityKey);
					results = new TList<GiangDaySauDaiHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangDaySauDaiHocSelectMethod.GetAll:
                    results = GiangDaySauDaiHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangDaySauDaiHocSelectMethod.GetPaged:
					results = GiangDaySauDaiHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangDaySauDaiHocSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangDaySauDaiHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangDaySauDaiHocProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangDaySauDaiHocSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = GiangDaySauDaiHocProvider.GetById(_id);
					results = new TList<GiangDaySauDaiHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case GiangDaySauDaiHocSelectMethod.GetByNamHocHocKy:
					sp114_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp114_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = GiangDaySauDaiHocProvider.GetByNamHocHocKy(sp114_NamHoc, sp114_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == GiangDaySauDaiHocSelectMethod.Get || SelectMethod == GiangDaySauDaiHocSelectMethod.GetById )
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
				GiangDaySauDaiHoc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangDaySauDaiHocProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangDaySauDaiHoc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangDaySauDaiHocProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangDaySauDaiHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangDaySauDaiHocDataSource class.
	/// </summary>
	public class GiangDaySauDaiHocDataSourceDesigner : ProviderDataSourceDesigner<GiangDaySauDaiHoc, GiangDaySauDaiHocKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangDaySauDaiHocDataSourceDesigner class.
		/// </summary>
		public GiangDaySauDaiHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangDaySauDaiHocSelectMethod SelectMethod
		{
			get { return ((GiangDaySauDaiHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangDaySauDaiHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangDaySauDaiHocDataSourceActionList

	/// <summary>
	/// Supports the GiangDaySauDaiHocDataSourceDesigner class.
	/// </summary>
	internal class GiangDaySauDaiHocDataSourceActionList : DesignerActionList
	{
		private GiangDaySauDaiHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangDaySauDaiHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangDaySauDaiHocDataSourceActionList(GiangDaySauDaiHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangDaySauDaiHocSelectMethod SelectMethod
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

	#endregion GiangDaySauDaiHocDataSourceActionList
	
	#endregion GiangDaySauDaiHocDataSourceDesigner
	
	#region GiangDaySauDaiHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangDaySauDaiHocDataSource.SelectMethod property.
	/// </summary>
	public enum GiangDaySauDaiHocSelectMethod
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
	
	#endregion GiangDaySauDaiHocSelectMethod

	#region GiangDaySauDaiHocFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangDaySauDaiHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangDaySauDaiHocFilter : SqlFilter<GiangDaySauDaiHocColumn>
	{
	}
	
	#endregion GiangDaySauDaiHocFilter

	#region GiangDaySauDaiHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangDaySauDaiHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangDaySauDaiHocExpressionBuilder : SqlExpressionBuilder<GiangDaySauDaiHocColumn>
	{
	}
	
	#endregion GiangDaySauDaiHocExpressionBuilder	

	#region GiangDaySauDaiHocProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangDaySauDaiHocChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangDaySauDaiHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangDaySauDaiHocProperty : ChildEntityProperty<GiangDaySauDaiHocChildEntityTypes>
	{
	}
	
	#endregion GiangDaySauDaiHocProperty
}

