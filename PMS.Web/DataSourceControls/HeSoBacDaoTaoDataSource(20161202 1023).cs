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
	/// Represents the DataRepository.HeSoBacDaoTaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoBacDaoTaoDataSourceDesigner))]
	public class HeSoBacDaoTaoDataSource : ProviderDataSource<HeSoBacDaoTao, HeSoBacDaoTaoKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoBacDaoTaoDataSource class.
		/// </summary>
		public HeSoBacDaoTaoDataSource() : base(new HeSoBacDaoTaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoBacDaoTaoDataSourceView used by the HeSoBacDaoTaoDataSource.
		/// </summary>
		protected HeSoBacDaoTaoDataSourceView HeSoBacDaoTaoView
		{
			get { return ( View as HeSoBacDaoTaoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoBacDaoTaoDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoBacDaoTaoSelectMethod SelectMethod
		{
			get
			{
				HeSoBacDaoTaoSelectMethod selectMethod = HeSoBacDaoTaoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoBacDaoTaoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoBacDaoTaoDataSourceView class that is to be
		/// used by the HeSoBacDaoTaoDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoBacDaoTaoDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoBacDaoTao, HeSoBacDaoTaoKey> GetNewDataSourceView()
		{
			return new HeSoBacDaoTaoDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoBacDaoTaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoBacDaoTaoDataSourceView : ProviderDataSourceView<HeSoBacDaoTao, HeSoBacDaoTaoKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoBacDaoTaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoBacDaoTaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoBacDaoTaoDataSourceView(HeSoBacDaoTaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoBacDaoTaoDataSource HeSoBacDaoTaoOwner
		{
			get { return Owner as HeSoBacDaoTaoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoBacDaoTaoSelectMethod SelectMethod
		{
			get { return HeSoBacDaoTaoOwner.SelectMethod; }
			set { HeSoBacDaoTaoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoBacDaoTaoService HeSoBacDaoTaoProvider
		{
			get { return Provider as HeSoBacDaoTaoService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoBacDaoTao> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoBacDaoTao> results = null;
			HeSoBacDaoTao item;
			count = 0;
			
			System.Int32 _maHeSo;
			System.String sp2344_MaBacDaoTao;
			System.String sp2344_MaKhoa;
			System.DateTime sp2344_NgayDay;
			System.String sp2346_NamHoc;
			System.String sp2346_HocKy;

			switch ( SelectMethod )
			{
				case HeSoBacDaoTaoSelectMethod.Get:
					HeSoBacDaoTaoKey entityKey  = new HeSoBacDaoTaoKey();
					entityKey.Load(values);
					item = HeSoBacDaoTaoProvider.Get(entityKey);
					results = new TList<HeSoBacDaoTao>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoBacDaoTaoSelectMethod.GetAll:
                    results = HeSoBacDaoTaoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoBacDaoTaoSelectMethod.GetPaged:
					results = HeSoBacDaoTaoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoBacDaoTaoSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoBacDaoTaoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoBacDaoTaoProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoBacDaoTaoSelectMethod.GetByMaHeSo:
					_maHeSo = ( values["MaHeSo"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHeSo"], typeof(System.Int32)) : (int)0;
					item = HeSoBacDaoTaoProvider.GetByMaHeSo(_maHeSo);
					results = new TList<HeSoBacDaoTao>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case HeSoBacDaoTaoSelectMethod.GetByBacDaoTaoKhoaNgayDay:
					sp2344_MaBacDaoTao = (System.String) EntityUtil.ChangeType(values["MaBacDaoTao"], typeof(System.String));
					sp2344_MaKhoa = (System.String) EntityUtil.ChangeType(values["MaKhoa"], typeof(System.String));
					sp2344_NgayDay = (System.DateTime) EntityUtil.ChangeType(values["NgayDay"], typeof(System.DateTime));
					results = HeSoBacDaoTaoProvider.GetByBacDaoTaoKhoaNgayDay(sp2344_MaBacDaoTao, sp2344_MaKhoa, sp2344_NgayDay, StartIndex, PageSize);
					break;
				case HeSoBacDaoTaoSelectMethod.GetByNamHocHocKy:
					sp2346_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2346_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = HeSoBacDaoTaoProvider.GetByNamHocHocKy(sp2346_NamHoc, sp2346_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == HeSoBacDaoTaoSelectMethod.Get || SelectMethod == HeSoBacDaoTaoSelectMethod.GetByMaHeSo )
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
				HeSoBacDaoTao entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoBacDaoTaoProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoBacDaoTao> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoBacDaoTaoProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoBacDaoTaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoBacDaoTaoDataSource class.
	/// </summary>
	public class HeSoBacDaoTaoDataSourceDesigner : ProviderDataSourceDesigner<HeSoBacDaoTao, HeSoBacDaoTaoKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoBacDaoTaoDataSourceDesigner class.
		/// </summary>
		public HeSoBacDaoTaoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoBacDaoTaoSelectMethod SelectMethod
		{
			get { return ((HeSoBacDaoTaoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoBacDaoTaoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoBacDaoTaoDataSourceActionList

	/// <summary>
	/// Supports the HeSoBacDaoTaoDataSourceDesigner class.
	/// </summary>
	internal class HeSoBacDaoTaoDataSourceActionList : DesignerActionList
	{
		private HeSoBacDaoTaoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoBacDaoTaoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoBacDaoTaoDataSourceActionList(HeSoBacDaoTaoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoBacDaoTaoSelectMethod SelectMethod
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

	#endregion HeSoBacDaoTaoDataSourceActionList
	
	#endregion HeSoBacDaoTaoDataSourceDesigner
	
	#region HeSoBacDaoTaoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoBacDaoTaoDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoBacDaoTaoSelectMethod
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
		/// Represents the GetByMaHeSo method.
		/// </summary>
		GetByMaHeSo,
		/// <summary>
		/// Represents the GetByBacDaoTaoKhoaNgayDay method.
		/// </summary>
		GetByBacDaoTaoKhoaNgayDay,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion HeSoBacDaoTaoSelectMethod

	#region HeSoBacDaoTaoFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoBacDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoBacDaoTaoFilter : SqlFilter<HeSoBacDaoTaoColumn>
	{
	}
	
	#endregion HeSoBacDaoTaoFilter

	#region HeSoBacDaoTaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoBacDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoBacDaoTaoExpressionBuilder : SqlExpressionBuilder<HeSoBacDaoTaoColumn>
	{
	}
	
	#endregion HeSoBacDaoTaoExpressionBuilder	

	#region HeSoBacDaoTaoProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoBacDaoTaoChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoBacDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoBacDaoTaoProperty : ChildEntityProperty<HeSoBacDaoTaoChildEntityTypes>
	{
	}
	
	#endregion HeSoBacDaoTaoProperty
}

