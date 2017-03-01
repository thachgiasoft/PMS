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
	/// Represents the DataRepository.PscExBarCodesProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(PscExBarCodesDataSourceDesigner))]
	public class PscExBarCodesDataSource : ProviderDataSource<PscExBarCodes, PscExBarCodesKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PscExBarCodesDataSource class.
		/// </summary>
		public PscExBarCodesDataSource() : base(new PscExBarCodesService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the PscExBarCodesDataSourceView used by the PscExBarCodesDataSource.
		/// </summary>
		protected PscExBarCodesDataSourceView PscExBarCodesView
		{
			get { return ( View as PscExBarCodesDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the PscExBarCodesDataSource control invokes to retrieve data.
		/// </summary>
		public PscExBarCodesSelectMethod SelectMethod
		{
			get
			{
				PscExBarCodesSelectMethod selectMethod = PscExBarCodesSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (PscExBarCodesSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the PscExBarCodesDataSourceView class that is to be
		/// used by the PscExBarCodesDataSource.
		/// </summary>
		/// <returns>An instance of the PscExBarCodesDataSourceView class.</returns>
		protected override BaseDataSourceView<PscExBarCodes, PscExBarCodesKey> GetNewDataSourceView()
		{
			return new PscExBarCodesDataSourceView(this, DefaultViewName);
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
	/// Supports the PscExBarCodesDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class PscExBarCodesDataSourceView : ProviderDataSourceView<PscExBarCodes, PscExBarCodesKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PscExBarCodesDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the PscExBarCodesDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public PscExBarCodesDataSourceView(PscExBarCodesDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal PscExBarCodesDataSource PscExBarCodesOwner
		{
			get { return Owner as PscExBarCodesDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal PscExBarCodesSelectMethod SelectMethod
		{
			get { return PscExBarCodesOwner.SelectMethod; }
			set { PscExBarCodesOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal PscExBarCodesService PscExBarCodesProvider
		{
			get { return Provider as PscExBarCodesService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<PscExBarCodes> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<PscExBarCodes> results = null;
			PscExBarCodes item;
			count = 0;
			
			System.String _maLopHocPhan;
			System.String _kyThi;
			System.Int32 _lanThi;
			System.String _barCode;

			switch ( SelectMethod )
			{
				case PscExBarCodesSelectMethod.Get:
					PscExBarCodesKey entityKey  = new PscExBarCodesKey();
					entityKey.Load(values);
					item = PscExBarCodesProvider.Get(entityKey);
					results = new TList<PscExBarCodes>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case PscExBarCodesSelectMethod.GetAll:
                    results = PscExBarCodesProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case PscExBarCodesSelectMethod.GetPaged:
					results = PscExBarCodesProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case PscExBarCodesSelectMethod.Find:
					if ( FilterParameters != null )
						results = PscExBarCodesProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = PscExBarCodesProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case PscExBarCodesSelectMethod.GetByMaLopHocPhanKyThiLanThiBarCode:
					_maLopHocPhan = ( values["MaLopHocPhan"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String)) : string.Empty;
					_kyThi = ( values["KyThi"] != null ) ? (System.String) EntityUtil.ChangeType(values["KyThi"], typeof(System.String)) : string.Empty;
					_lanThi = ( values["LanThi"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["LanThi"], typeof(System.Int32)) : (int)0;
					_barCode = ( values["BarCode"] != null ) ? (System.String) EntityUtil.ChangeType(values["BarCode"], typeof(System.String)) : string.Empty;
					item = PscExBarCodesProvider.GetByMaLopHocPhanKyThiLanThiBarCode(_maLopHocPhan, _kyThi, _lanThi, _barCode);
					results = new TList<PscExBarCodes>();
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
			if ( SelectMethod == PscExBarCodesSelectMethod.Get || SelectMethod == PscExBarCodesSelectMethod.GetByMaLopHocPhanKyThiLanThiBarCode )
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
				PscExBarCodes entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					PscExBarCodesProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<PscExBarCodes> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			PscExBarCodesProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region PscExBarCodesDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the PscExBarCodesDataSource class.
	/// </summary>
	public class PscExBarCodesDataSourceDesigner : ProviderDataSourceDesigner<PscExBarCodes, PscExBarCodesKey>
	{
		/// <summary>
		/// Initializes a new instance of the PscExBarCodesDataSourceDesigner class.
		/// </summary>
		public PscExBarCodesDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public PscExBarCodesSelectMethod SelectMethod
		{
			get { return ((PscExBarCodesDataSource) DataSource).SelectMethod; }
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
				actions.Add(new PscExBarCodesDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region PscExBarCodesDataSourceActionList

	/// <summary>
	/// Supports the PscExBarCodesDataSourceDesigner class.
	/// </summary>
	internal class PscExBarCodesDataSourceActionList : DesignerActionList
	{
		private PscExBarCodesDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the PscExBarCodesDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public PscExBarCodesDataSourceActionList(PscExBarCodesDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public PscExBarCodesSelectMethod SelectMethod
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

	#endregion PscExBarCodesDataSourceActionList
	
	#endregion PscExBarCodesDataSourceDesigner
	
	#region PscExBarCodesSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the PscExBarCodesDataSource.SelectMethod property.
	/// </summary>
	public enum PscExBarCodesSelectMethod
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
		/// Represents the GetByMaLopHocPhanKyThiLanThiBarCode method.
		/// </summary>
		GetByMaLopHocPhanKyThiLanThiBarCode
	}
	
	#endregion PscExBarCodesSelectMethod

	#region PscExBarCodesFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PscExBarCodes"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PscExBarCodesFilter : SqlFilter<PscExBarCodesColumn>
	{
	}
	
	#endregion PscExBarCodesFilter

	#region PscExBarCodesExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PscExBarCodes"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PscExBarCodesExpressionBuilder : SqlExpressionBuilder<PscExBarCodesColumn>
	{
	}
	
	#endregion PscExBarCodesExpressionBuilder	

	#region PscExBarCodesProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;PscExBarCodesChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="PscExBarCodes"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PscExBarCodesProperty : ChildEntityProperty<PscExBarCodesChildEntityTypes>
	{
	}
	
	#endregion PscExBarCodesProperty
}

