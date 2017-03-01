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
	/// Represents the DataRepository.GiangDayChatLuongCaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangDayChatLuongCaoDataSourceDesigner))]
	public class GiangDayChatLuongCaoDataSource : ProviderDataSource<GiangDayChatLuongCao, GiangDayChatLuongCaoKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangDayChatLuongCaoDataSource class.
		/// </summary>
		public GiangDayChatLuongCaoDataSource() : base(new GiangDayChatLuongCaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangDayChatLuongCaoDataSourceView used by the GiangDayChatLuongCaoDataSource.
		/// </summary>
		protected GiangDayChatLuongCaoDataSourceView GiangDayChatLuongCaoView
		{
			get { return ( View as GiangDayChatLuongCaoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangDayChatLuongCaoDataSource control invokes to retrieve data.
		/// </summary>
		public GiangDayChatLuongCaoSelectMethod SelectMethod
		{
			get
			{
				GiangDayChatLuongCaoSelectMethod selectMethod = GiangDayChatLuongCaoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangDayChatLuongCaoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangDayChatLuongCaoDataSourceView class that is to be
		/// used by the GiangDayChatLuongCaoDataSource.
		/// </summary>
		/// <returns>An instance of the GiangDayChatLuongCaoDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangDayChatLuongCao, GiangDayChatLuongCaoKey> GetNewDataSourceView()
		{
			return new GiangDayChatLuongCaoDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangDayChatLuongCaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangDayChatLuongCaoDataSourceView : ProviderDataSourceView<GiangDayChatLuongCao, GiangDayChatLuongCaoKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangDayChatLuongCaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangDayChatLuongCaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangDayChatLuongCaoDataSourceView(GiangDayChatLuongCaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangDayChatLuongCaoDataSource GiangDayChatLuongCaoOwner
		{
			get { return Owner as GiangDayChatLuongCaoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangDayChatLuongCaoSelectMethod SelectMethod
		{
			get { return GiangDayChatLuongCaoOwner.SelectMethod; }
			set { GiangDayChatLuongCaoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangDayChatLuongCaoService GiangDayChatLuongCaoProvider
		{
			get { return Provider as GiangDayChatLuongCaoService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangDayChatLuongCao> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangDayChatLuongCao> results = null;
			GiangDayChatLuongCao item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2210_NamHoc;
			System.String sp2210_HocKy;

			switch ( SelectMethod )
			{
				case GiangDayChatLuongCaoSelectMethod.Get:
					GiangDayChatLuongCaoKey entityKey  = new GiangDayChatLuongCaoKey();
					entityKey.Load(values);
					item = GiangDayChatLuongCaoProvider.Get(entityKey);
					results = new TList<GiangDayChatLuongCao>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangDayChatLuongCaoSelectMethod.GetAll:
                    results = GiangDayChatLuongCaoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangDayChatLuongCaoSelectMethod.GetPaged:
					results = GiangDayChatLuongCaoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangDayChatLuongCaoSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangDayChatLuongCaoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangDayChatLuongCaoProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangDayChatLuongCaoSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = GiangDayChatLuongCaoProvider.GetById(_id);
					results = new TList<GiangDayChatLuongCao>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case GiangDayChatLuongCaoSelectMethod.GetByNamHocHocKy:
					sp2210_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2210_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = GiangDayChatLuongCaoProvider.GetByNamHocHocKy(sp2210_NamHoc, sp2210_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == GiangDayChatLuongCaoSelectMethod.Get || SelectMethod == GiangDayChatLuongCaoSelectMethod.GetById )
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
				GiangDayChatLuongCao entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangDayChatLuongCaoProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangDayChatLuongCao> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangDayChatLuongCaoProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangDayChatLuongCaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangDayChatLuongCaoDataSource class.
	/// </summary>
	public class GiangDayChatLuongCaoDataSourceDesigner : ProviderDataSourceDesigner<GiangDayChatLuongCao, GiangDayChatLuongCaoKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangDayChatLuongCaoDataSourceDesigner class.
		/// </summary>
		public GiangDayChatLuongCaoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangDayChatLuongCaoSelectMethod SelectMethod
		{
			get { return ((GiangDayChatLuongCaoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangDayChatLuongCaoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangDayChatLuongCaoDataSourceActionList

	/// <summary>
	/// Supports the GiangDayChatLuongCaoDataSourceDesigner class.
	/// </summary>
	internal class GiangDayChatLuongCaoDataSourceActionList : DesignerActionList
	{
		private GiangDayChatLuongCaoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangDayChatLuongCaoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangDayChatLuongCaoDataSourceActionList(GiangDayChatLuongCaoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangDayChatLuongCaoSelectMethod SelectMethod
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

	#endregion GiangDayChatLuongCaoDataSourceActionList
	
	#endregion GiangDayChatLuongCaoDataSourceDesigner
	
	#region GiangDayChatLuongCaoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangDayChatLuongCaoDataSource.SelectMethod property.
	/// </summary>
	public enum GiangDayChatLuongCaoSelectMethod
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
	
	#endregion GiangDayChatLuongCaoSelectMethod

	#region GiangDayChatLuongCaoFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangDayChatLuongCao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangDayChatLuongCaoFilter : SqlFilter<GiangDayChatLuongCaoColumn>
	{
	}
	
	#endregion GiangDayChatLuongCaoFilter

	#region GiangDayChatLuongCaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangDayChatLuongCao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangDayChatLuongCaoExpressionBuilder : SqlExpressionBuilder<GiangDayChatLuongCaoColumn>
	{
	}
	
	#endregion GiangDayChatLuongCaoExpressionBuilder	

	#region GiangDayChatLuongCaoProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangDayChatLuongCaoChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangDayChatLuongCao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangDayChatLuongCaoProperty : ChildEntityProperty<GiangDayChatLuongCaoChildEntityTypes>
	{
	}
	
	#endregion GiangDayChatLuongCaoProperty
}

