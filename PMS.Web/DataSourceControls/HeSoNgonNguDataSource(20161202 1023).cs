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
	/// Represents the DataRepository.HeSoNgonNguProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoNgonNguDataSourceDesigner))]
	public class HeSoNgonNguDataSource : ProviderDataSource<HeSoNgonNgu, HeSoNgonNguKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoNgonNguDataSource class.
		/// </summary>
		public HeSoNgonNguDataSource() : base(new HeSoNgonNguService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoNgonNguDataSourceView used by the HeSoNgonNguDataSource.
		/// </summary>
		protected HeSoNgonNguDataSourceView HeSoNgonNguView
		{
			get { return ( View as HeSoNgonNguDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoNgonNguDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoNgonNguSelectMethod SelectMethod
		{
			get
			{
				HeSoNgonNguSelectMethod selectMethod = HeSoNgonNguSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoNgonNguSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoNgonNguDataSourceView class that is to be
		/// used by the HeSoNgonNguDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoNgonNguDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoNgonNgu, HeSoNgonNguKey> GetNewDataSourceView()
		{
			return new HeSoNgonNguDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoNgonNguDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoNgonNguDataSourceView : ProviderDataSourceView<HeSoNgonNgu, HeSoNgonNguKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoNgonNguDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoNgonNguDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoNgonNguDataSourceView(HeSoNgonNguDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoNgonNguDataSource HeSoNgonNguOwner
		{
			get { return Owner as HeSoNgonNguDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoNgonNguSelectMethod SelectMethod
		{
			get { return HeSoNgonNguOwner.SelectMethod; }
			set { HeSoNgonNguOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoNgonNguService HeSoNgonNguProvider
		{
			get { return Provider as HeSoNgonNguService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoNgonNgu> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoNgonNgu> results = null;
			HeSoNgonNgu item;
			count = 0;
			
			System.Int32 _maHeSo;
			System.String sp2400_MaLopHocPhan;
			System.DateTime sp2400_NgayDay;
			System.String sp2402_NamHoc;
			System.String sp2402_HocKy;

			switch ( SelectMethod )
			{
				case HeSoNgonNguSelectMethod.Get:
					HeSoNgonNguKey entityKey  = new HeSoNgonNguKey();
					entityKey.Load(values);
					item = HeSoNgonNguProvider.Get(entityKey);
					results = new TList<HeSoNgonNgu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoNgonNguSelectMethod.GetAll:
                    results = HeSoNgonNguProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoNgonNguSelectMethod.GetPaged:
					results = HeSoNgonNguProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoNgonNguSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoNgonNguProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoNgonNguProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoNgonNguSelectMethod.GetByMaHeSo:
					_maHeSo = ( values["MaHeSo"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHeSo"], typeof(System.Int32)) : (int)0;
					item = HeSoNgonNguProvider.GetByMaHeSo(_maHeSo);
					results = new TList<HeSoNgonNgu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case HeSoNgonNguSelectMethod.GetByMaLopHocPhanNgayDay:
					sp2400_MaLopHocPhan = (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String));
					sp2400_NgayDay = (System.DateTime) EntityUtil.ChangeType(values["NgayDay"], typeof(System.DateTime));
					results = HeSoNgonNguProvider.GetByMaLopHocPhanNgayDay(sp2400_MaLopHocPhan, sp2400_NgayDay, StartIndex, PageSize);
					break;
				case HeSoNgonNguSelectMethod.GetByNamHocKocKy:
					sp2402_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2402_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = HeSoNgonNguProvider.GetByNamHocKocKy(sp2402_NamHoc, sp2402_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == HeSoNgonNguSelectMethod.Get || SelectMethod == HeSoNgonNguSelectMethod.GetByMaHeSo )
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
				HeSoNgonNgu entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoNgonNguProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoNgonNgu> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoNgonNguProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoNgonNguDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoNgonNguDataSource class.
	/// </summary>
	public class HeSoNgonNguDataSourceDesigner : ProviderDataSourceDesigner<HeSoNgonNgu, HeSoNgonNguKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoNgonNguDataSourceDesigner class.
		/// </summary>
		public HeSoNgonNguDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoNgonNguSelectMethod SelectMethod
		{
			get { return ((HeSoNgonNguDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoNgonNguDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoNgonNguDataSourceActionList

	/// <summary>
	/// Supports the HeSoNgonNguDataSourceDesigner class.
	/// </summary>
	internal class HeSoNgonNguDataSourceActionList : DesignerActionList
	{
		private HeSoNgonNguDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoNgonNguDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoNgonNguDataSourceActionList(HeSoNgonNguDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoNgonNguSelectMethod SelectMethod
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

	#endregion HeSoNgonNguDataSourceActionList
	
	#endregion HeSoNgonNguDataSourceDesigner
	
	#region HeSoNgonNguSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoNgonNguDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoNgonNguSelectMethod
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
		/// Represents the GetByMaLopHocPhanNgayDay method.
		/// </summary>
		GetByMaLopHocPhanNgayDay,
		/// <summary>
		/// Represents the GetByNamHocKocKy method.
		/// </summary>
		GetByNamHocKocKy
	}
	
	#endregion HeSoNgonNguSelectMethod

	#region HeSoNgonNguFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoNgonNgu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoNgonNguFilter : SqlFilter<HeSoNgonNguColumn>
	{
	}
	
	#endregion HeSoNgonNguFilter

	#region HeSoNgonNguExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoNgonNgu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoNgonNguExpressionBuilder : SqlExpressionBuilder<HeSoNgonNguColumn>
	{
	}
	
	#endregion HeSoNgonNguExpressionBuilder	

	#region HeSoNgonNguProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoNgonNguChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoNgonNgu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoNgonNguProperty : ChildEntityProperty<HeSoNgonNguChildEntityTypes>
	{
	}
	
	#endregion HeSoNgonNguProperty
}

