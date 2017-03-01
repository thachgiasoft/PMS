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
	/// Represents the DataRepository.HeSoCoSoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoCoSoDataSourceDesigner))]
	public class HeSoCoSoDataSource : ProviderDataSource<HeSoCoSo, HeSoCoSoKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoCoSoDataSource class.
		/// </summary>
		public HeSoCoSoDataSource() : base(new HeSoCoSoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoCoSoDataSourceView used by the HeSoCoSoDataSource.
		/// </summary>
		protected HeSoCoSoDataSourceView HeSoCoSoView
		{
			get { return ( View as HeSoCoSoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoCoSoDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoCoSoSelectMethod SelectMethod
		{
			get
			{
				HeSoCoSoSelectMethod selectMethod = HeSoCoSoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoCoSoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoCoSoDataSourceView class that is to be
		/// used by the HeSoCoSoDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoCoSoDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoCoSo, HeSoCoSoKey> GetNewDataSourceView()
		{
			return new HeSoCoSoDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoCoSoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoCoSoDataSourceView : ProviderDataSourceView<HeSoCoSo, HeSoCoSoKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoCoSoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoCoSoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoCoSoDataSourceView(HeSoCoSoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoCoSoDataSource HeSoCoSoOwner
		{
			get { return Owner as HeSoCoSoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoCoSoSelectMethod SelectMethod
		{
			get { return HeSoCoSoOwner.SelectMethod; }
			set { HeSoCoSoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoCoSoService HeSoCoSoProvider
		{
			get { return Provider as HeSoCoSoService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoCoSo> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoCoSo> results = null;
			HeSoCoSo item;
			count = 0;
			
			System.Int32 _maHeSo;
			System.String sp2364_NamHoc;
			System.String sp2364_HocKy;
			System.String sp2363_NamHoc;
			System.String sp2363_HocKy;
			System.String sp2363_MaPhongHoc;
			System.DateTime sp2363_NgayDay;
			System.String sp2362_MaPhongHoc;
			System.DateTime sp2362_NgayDay;

			switch ( SelectMethod )
			{
				case HeSoCoSoSelectMethod.Get:
					HeSoCoSoKey entityKey  = new HeSoCoSoKey();
					entityKey.Load(values);
					item = HeSoCoSoProvider.Get(entityKey);
					results = new TList<HeSoCoSo>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoCoSoSelectMethod.GetAll:
                    results = HeSoCoSoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoCoSoSelectMethod.GetPaged:
					results = HeSoCoSoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoCoSoSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoCoSoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoCoSoProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoCoSoSelectMethod.GetByMaHeSo:
					_maHeSo = ( values["MaHeSo"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHeSo"], typeof(System.Int32)) : (int)0;
					item = HeSoCoSoProvider.GetByMaHeSo(_maHeSo);
					results = new TList<HeSoCoSo>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case HeSoCoSoSelectMethod.GetByNamHocHocKy:
					sp2364_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2364_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = HeSoCoSoProvider.GetByNamHocHocKy(sp2364_NamHoc, sp2364_HocKy, StartIndex, PageSize);
					break;
				case HeSoCoSoSelectMethod.GetByMaPhongHocNgayDayByNamHocHocKy:
					sp2363_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2363_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp2363_MaPhongHoc = (System.String) EntityUtil.ChangeType(values["MaPhongHoc"], typeof(System.String));
					sp2363_NgayDay = (System.DateTime) EntityUtil.ChangeType(values["NgayDay"], typeof(System.DateTime));
					results = HeSoCoSoProvider.GetByMaPhongHocNgayDayByNamHocHocKy(sp2363_NamHoc, sp2363_HocKy, sp2363_MaPhongHoc, sp2363_NgayDay, StartIndex, PageSize);
					break;
				case HeSoCoSoSelectMethod.GetByMaPhongHocNgayDay:
					sp2362_MaPhongHoc = (System.String) EntityUtil.ChangeType(values["MaPhongHoc"], typeof(System.String));
					sp2362_NgayDay = (System.DateTime) EntityUtil.ChangeType(values["NgayDay"], typeof(System.DateTime));
					results = HeSoCoSoProvider.GetByMaPhongHocNgayDay(sp2362_MaPhongHoc, sp2362_NgayDay, StartIndex, PageSize);
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
			if ( SelectMethod == HeSoCoSoSelectMethod.Get || SelectMethod == HeSoCoSoSelectMethod.GetByMaHeSo )
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
				HeSoCoSo entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoCoSoProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoCoSo> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoCoSoProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoCoSoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoCoSoDataSource class.
	/// </summary>
	public class HeSoCoSoDataSourceDesigner : ProviderDataSourceDesigner<HeSoCoSo, HeSoCoSoKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoCoSoDataSourceDesigner class.
		/// </summary>
		public HeSoCoSoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoCoSoSelectMethod SelectMethod
		{
			get { return ((HeSoCoSoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoCoSoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoCoSoDataSourceActionList

	/// <summary>
	/// Supports the HeSoCoSoDataSourceDesigner class.
	/// </summary>
	internal class HeSoCoSoDataSourceActionList : DesignerActionList
	{
		private HeSoCoSoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoCoSoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoCoSoDataSourceActionList(HeSoCoSoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoCoSoSelectMethod SelectMethod
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

	#endregion HeSoCoSoDataSourceActionList
	
	#endregion HeSoCoSoDataSourceDesigner
	
	#region HeSoCoSoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoCoSoDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoCoSoSelectMethod
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
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy,
		/// <summary>
		/// Represents the GetByMaPhongHocNgayDayByNamHocHocKy method.
		/// </summary>
		GetByMaPhongHocNgayDayByNamHocHocKy,
		/// <summary>
		/// Represents the GetByMaPhongHocNgayDay method.
		/// </summary>
		GetByMaPhongHocNgayDay
	}
	
	#endregion HeSoCoSoSelectMethod

	#region HeSoCoSoFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoCoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoCoSoFilter : SqlFilter<HeSoCoSoColumn>
	{
	}
	
	#endregion HeSoCoSoFilter

	#region HeSoCoSoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoCoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoCoSoExpressionBuilder : SqlExpressionBuilder<HeSoCoSoColumn>
	{
	}
	
	#endregion HeSoCoSoExpressionBuilder	

	#region HeSoCoSoProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoCoSoChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoCoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoCoSoProperty : ChildEntityProperty<HeSoCoSoChildEntityTypes>
	{
	}
	
	#endregion HeSoCoSoProperty
}

