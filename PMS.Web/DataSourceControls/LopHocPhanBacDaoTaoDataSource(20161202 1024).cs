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
	/// Represents the DataRepository.LopHocPhanBacDaoTaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(LopHocPhanBacDaoTaoDataSourceDesigner))]
	public class LopHocPhanBacDaoTaoDataSource : ProviderDataSource<LopHocPhanBacDaoTao, LopHocPhanBacDaoTaoKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanBacDaoTaoDataSource class.
		/// </summary>
		public LopHocPhanBacDaoTaoDataSource() : base(new LopHocPhanBacDaoTaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the LopHocPhanBacDaoTaoDataSourceView used by the LopHocPhanBacDaoTaoDataSource.
		/// </summary>
		protected LopHocPhanBacDaoTaoDataSourceView LopHocPhanBacDaoTaoView
		{
			get { return ( View as LopHocPhanBacDaoTaoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the LopHocPhanBacDaoTaoDataSource control invokes to retrieve data.
		/// </summary>
		public LopHocPhanBacDaoTaoSelectMethod SelectMethod
		{
			get
			{
				LopHocPhanBacDaoTaoSelectMethod selectMethod = LopHocPhanBacDaoTaoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (LopHocPhanBacDaoTaoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the LopHocPhanBacDaoTaoDataSourceView class that is to be
		/// used by the LopHocPhanBacDaoTaoDataSource.
		/// </summary>
		/// <returns>An instance of the LopHocPhanBacDaoTaoDataSourceView class.</returns>
		protected override BaseDataSourceView<LopHocPhanBacDaoTao, LopHocPhanBacDaoTaoKey> GetNewDataSourceView()
		{
			return new LopHocPhanBacDaoTaoDataSourceView(this, DefaultViewName);
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
	/// Supports the LopHocPhanBacDaoTaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class LopHocPhanBacDaoTaoDataSourceView : ProviderDataSourceView<LopHocPhanBacDaoTao, LopHocPhanBacDaoTaoKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanBacDaoTaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the LopHocPhanBacDaoTaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public LopHocPhanBacDaoTaoDataSourceView(LopHocPhanBacDaoTaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal LopHocPhanBacDaoTaoDataSource LopHocPhanBacDaoTaoOwner
		{
			get { return Owner as LopHocPhanBacDaoTaoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal LopHocPhanBacDaoTaoSelectMethod SelectMethod
		{
			get { return LopHocPhanBacDaoTaoOwner.SelectMethod; }
			set { LopHocPhanBacDaoTaoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal LopHocPhanBacDaoTaoService LopHocPhanBacDaoTaoProvider
		{
			get { return Provider as LopHocPhanBacDaoTaoService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<LopHocPhanBacDaoTao> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<LopHocPhanBacDaoTao> results = null;
			LopHocPhanBacDaoTao item;
			count = 0;
			
			System.String _maLopHocPhan;
			System.Int32 _maHeSoBacDaoTao;
			System.String sp2741_NamHoc;
			System.String sp2741_HocKy;

			switch ( SelectMethod )
			{
				case LopHocPhanBacDaoTaoSelectMethod.Get:
					LopHocPhanBacDaoTaoKey entityKey  = new LopHocPhanBacDaoTaoKey();
					entityKey.Load(values);
					item = LopHocPhanBacDaoTaoProvider.Get(entityKey);
					results = new TList<LopHocPhanBacDaoTao>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case LopHocPhanBacDaoTaoSelectMethod.GetAll:
                    results = LopHocPhanBacDaoTaoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case LopHocPhanBacDaoTaoSelectMethod.GetPaged:
					results = LopHocPhanBacDaoTaoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case LopHocPhanBacDaoTaoSelectMethod.Find:
					if ( FilterParameters != null )
						results = LopHocPhanBacDaoTaoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = LopHocPhanBacDaoTaoProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case LopHocPhanBacDaoTaoSelectMethod.GetByMaLopHocPhanMaHeSoBacDaoTao:
					_maLopHocPhan = ( values["MaLopHocPhan"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String)) : string.Empty;
					_maHeSoBacDaoTao = ( values["MaHeSoBacDaoTao"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHeSoBacDaoTao"], typeof(System.Int32)) : (int)0;
					item = LopHocPhanBacDaoTaoProvider.GetByMaLopHocPhanMaHeSoBacDaoTao(_maLopHocPhan, _maHeSoBacDaoTao);
					results = new TList<LopHocPhanBacDaoTao>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case LopHocPhanBacDaoTaoSelectMethod.GetByMaHeSoBacDaoTao:
					_maHeSoBacDaoTao = ( values["MaHeSoBacDaoTao"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHeSoBacDaoTao"], typeof(System.Int32)) : (int)0;
					results = LopHocPhanBacDaoTaoProvider.GetByMaHeSoBacDaoTao(_maHeSoBacDaoTao, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				case LopHocPhanBacDaoTaoSelectMethod.GetByNamHocHocKy:
					sp2741_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2741_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = LopHocPhanBacDaoTaoProvider.GetByNamHocHocKy(sp2741_NamHoc, sp2741_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == LopHocPhanBacDaoTaoSelectMethod.Get || SelectMethod == LopHocPhanBacDaoTaoSelectMethod.GetByMaLopHocPhanMaHeSoBacDaoTao )
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
				LopHocPhanBacDaoTao entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					LopHocPhanBacDaoTaoProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<LopHocPhanBacDaoTao> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			LopHocPhanBacDaoTaoProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region LopHocPhanBacDaoTaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the LopHocPhanBacDaoTaoDataSource class.
	/// </summary>
	public class LopHocPhanBacDaoTaoDataSourceDesigner : ProviderDataSourceDesigner<LopHocPhanBacDaoTao, LopHocPhanBacDaoTaoKey>
	{
		/// <summary>
		/// Initializes a new instance of the LopHocPhanBacDaoTaoDataSourceDesigner class.
		/// </summary>
		public LopHocPhanBacDaoTaoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LopHocPhanBacDaoTaoSelectMethod SelectMethod
		{
			get { return ((LopHocPhanBacDaoTaoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new LopHocPhanBacDaoTaoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region LopHocPhanBacDaoTaoDataSourceActionList

	/// <summary>
	/// Supports the LopHocPhanBacDaoTaoDataSourceDesigner class.
	/// </summary>
	internal class LopHocPhanBacDaoTaoDataSourceActionList : DesignerActionList
	{
		private LopHocPhanBacDaoTaoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the LopHocPhanBacDaoTaoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public LopHocPhanBacDaoTaoDataSourceActionList(LopHocPhanBacDaoTaoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LopHocPhanBacDaoTaoSelectMethod SelectMethod
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

	#endregion LopHocPhanBacDaoTaoDataSourceActionList
	
	#endregion LopHocPhanBacDaoTaoDataSourceDesigner
	
	#region LopHocPhanBacDaoTaoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the LopHocPhanBacDaoTaoDataSource.SelectMethod property.
	/// </summary>
	public enum LopHocPhanBacDaoTaoSelectMethod
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
		/// Represents the GetByMaLopHocPhanMaHeSoBacDaoTao method.
		/// </summary>
		GetByMaLopHocPhanMaHeSoBacDaoTao,
		/// <summary>
		/// Represents the GetByMaHeSoBacDaoTao method.
		/// </summary>
		GetByMaHeSoBacDaoTao,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion LopHocPhanBacDaoTaoSelectMethod

	#region LopHocPhanBacDaoTaoFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanBacDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanBacDaoTaoFilter : SqlFilter<LopHocPhanBacDaoTaoColumn>
	{
	}
	
	#endregion LopHocPhanBacDaoTaoFilter

	#region LopHocPhanBacDaoTaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanBacDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanBacDaoTaoExpressionBuilder : SqlExpressionBuilder<LopHocPhanBacDaoTaoColumn>
	{
	}
	
	#endregion LopHocPhanBacDaoTaoExpressionBuilder	

	#region LopHocPhanBacDaoTaoProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;LopHocPhanBacDaoTaoChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanBacDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanBacDaoTaoProperty : ChildEntityProperty<LopHocPhanBacDaoTaoChildEntityTypes>
	{
	}
	
	#endregion LopHocPhanBacDaoTaoProperty
}

