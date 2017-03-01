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
	/// Represents the DataRepository.DinhMucGioChuanToiThieuTheoChucVuProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DinhMucGioChuanToiThieuTheoChucVuDataSourceDesigner))]
	public class DinhMucGioChuanToiThieuTheoChucVuDataSource : ProviderDataSource<DinhMucGioChuanToiThieuTheoChucVu, DinhMucGioChuanToiThieuTheoChucVuKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanToiThieuTheoChucVuDataSource class.
		/// </summary>
		public DinhMucGioChuanToiThieuTheoChucVuDataSource() : base(new DinhMucGioChuanToiThieuTheoChucVuService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DinhMucGioChuanToiThieuTheoChucVuDataSourceView used by the DinhMucGioChuanToiThieuTheoChucVuDataSource.
		/// </summary>
		protected DinhMucGioChuanToiThieuTheoChucVuDataSourceView DinhMucGioChuanToiThieuTheoChucVuView
		{
			get { return ( View as DinhMucGioChuanToiThieuTheoChucVuDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DinhMucGioChuanToiThieuTheoChucVuDataSource control invokes to retrieve data.
		/// </summary>
		public DinhMucGioChuanToiThieuTheoChucVuSelectMethod SelectMethod
		{
			get
			{
				DinhMucGioChuanToiThieuTheoChucVuSelectMethod selectMethod = DinhMucGioChuanToiThieuTheoChucVuSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DinhMucGioChuanToiThieuTheoChucVuSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DinhMucGioChuanToiThieuTheoChucVuDataSourceView class that is to be
		/// used by the DinhMucGioChuanToiThieuTheoChucVuDataSource.
		/// </summary>
		/// <returns>An instance of the DinhMucGioChuanToiThieuTheoChucVuDataSourceView class.</returns>
		protected override BaseDataSourceView<DinhMucGioChuanToiThieuTheoChucVu, DinhMucGioChuanToiThieuTheoChucVuKey> GetNewDataSourceView()
		{
			return new DinhMucGioChuanToiThieuTheoChucVuDataSourceView(this, DefaultViewName);
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
	/// Supports the DinhMucGioChuanToiThieuTheoChucVuDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DinhMucGioChuanToiThieuTheoChucVuDataSourceView : ProviderDataSourceView<DinhMucGioChuanToiThieuTheoChucVu, DinhMucGioChuanToiThieuTheoChucVuKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanToiThieuTheoChucVuDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DinhMucGioChuanToiThieuTheoChucVuDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DinhMucGioChuanToiThieuTheoChucVuDataSourceView(DinhMucGioChuanToiThieuTheoChucVuDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DinhMucGioChuanToiThieuTheoChucVuDataSource DinhMucGioChuanToiThieuTheoChucVuOwner
		{
			get { return Owner as DinhMucGioChuanToiThieuTheoChucVuDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DinhMucGioChuanToiThieuTheoChucVuSelectMethod SelectMethod
		{
			get { return DinhMucGioChuanToiThieuTheoChucVuOwner.SelectMethod; }
			set { DinhMucGioChuanToiThieuTheoChucVuOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DinhMucGioChuanToiThieuTheoChucVuService DinhMucGioChuanToiThieuTheoChucVuProvider
		{
			get { return Provider as DinhMucGioChuanToiThieuTheoChucVuService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DinhMucGioChuanToiThieuTheoChucVu> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DinhMucGioChuanToiThieuTheoChucVu> results = null;
			DinhMucGioChuanToiThieuTheoChucVu item;
			count = 0;
			
			System.Int32 _id;
			System.Int32? _maChucVu_nullable;
			System.Int32? _idQuyMo_nullable;
			System.String sp67_NamHoc;
			System.String sp67_HocKy;
			System.String sp66_NamHoc;

			switch ( SelectMethod )
			{
				case DinhMucGioChuanToiThieuTheoChucVuSelectMethod.Get:
					DinhMucGioChuanToiThieuTheoChucVuKey entityKey  = new DinhMucGioChuanToiThieuTheoChucVuKey();
					entityKey.Load(values);
					item = DinhMucGioChuanToiThieuTheoChucVuProvider.Get(entityKey);
					results = new TList<DinhMucGioChuanToiThieuTheoChucVu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DinhMucGioChuanToiThieuTheoChucVuSelectMethod.GetAll:
                    results = DinhMucGioChuanToiThieuTheoChucVuProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DinhMucGioChuanToiThieuTheoChucVuSelectMethod.GetPaged:
					results = DinhMucGioChuanToiThieuTheoChucVuProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DinhMucGioChuanToiThieuTheoChucVuSelectMethod.Find:
					if ( FilterParameters != null )
						results = DinhMucGioChuanToiThieuTheoChucVuProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DinhMucGioChuanToiThieuTheoChucVuProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DinhMucGioChuanToiThieuTheoChucVuSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = DinhMucGioChuanToiThieuTheoChucVuProvider.GetById(_id);
					results = new TList<DinhMucGioChuanToiThieuTheoChucVu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case DinhMucGioChuanToiThieuTheoChucVuSelectMethod.GetByMaChucVu:
					_maChucVu_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaChucVu"], typeof(System.Int32?));
					results = DinhMucGioChuanToiThieuTheoChucVuProvider.GetByMaChucVu(_maChucVu_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case DinhMucGioChuanToiThieuTheoChucVuSelectMethod.GetByIdQuyMo:
					_idQuyMo_nullable = (System.Int32?) EntityUtil.ChangeType(values["IdQuyMo"], typeof(System.Int32?));
					results = DinhMucGioChuanToiThieuTheoChucVuProvider.GetByIdQuyMo(_idQuyMo_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				case DinhMucGioChuanToiThieuTheoChucVuSelectMethod.GetByNamHocHocKy:
					sp67_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp67_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = DinhMucGioChuanToiThieuTheoChucVuProvider.GetByNamHocHocKy(sp67_NamHoc, sp67_HocKy, StartIndex, PageSize);
					break;
				case DinhMucGioChuanToiThieuTheoChucVuSelectMethod.GetByNamHoc:
					sp66_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					results = DinhMucGioChuanToiThieuTheoChucVuProvider.GetByNamHoc(sp66_NamHoc, StartIndex, PageSize);
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
			if ( SelectMethod == DinhMucGioChuanToiThieuTheoChucVuSelectMethod.Get || SelectMethod == DinhMucGioChuanToiThieuTheoChucVuSelectMethod.GetById )
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
				DinhMucGioChuanToiThieuTheoChucVu entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DinhMucGioChuanToiThieuTheoChucVuProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DinhMucGioChuanToiThieuTheoChucVu> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DinhMucGioChuanToiThieuTheoChucVuProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DinhMucGioChuanToiThieuTheoChucVuDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DinhMucGioChuanToiThieuTheoChucVuDataSource class.
	/// </summary>
	public class DinhMucGioChuanToiThieuTheoChucVuDataSourceDesigner : ProviderDataSourceDesigner<DinhMucGioChuanToiThieuTheoChucVu, DinhMucGioChuanToiThieuTheoChucVuKey>
	{
		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanToiThieuTheoChucVuDataSourceDesigner class.
		/// </summary>
		public DinhMucGioChuanToiThieuTheoChucVuDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DinhMucGioChuanToiThieuTheoChucVuSelectMethod SelectMethod
		{
			get { return ((DinhMucGioChuanToiThieuTheoChucVuDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DinhMucGioChuanToiThieuTheoChucVuDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DinhMucGioChuanToiThieuTheoChucVuDataSourceActionList

	/// <summary>
	/// Supports the DinhMucGioChuanToiThieuTheoChucVuDataSourceDesigner class.
	/// </summary>
	internal class DinhMucGioChuanToiThieuTheoChucVuDataSourceActionList : DesignerActionList
	{
		private DinhMucGioChuanToiThieuTheoChucVuDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanToiThieuTheoChucVuDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DinhMucGioChuanToiThieuTheoChucVuDataSourceActionList(DinhMucGioChuanToiThieuTheoChucVuDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DinhMucGioChuanToiThieuTheoChucVuSelectMethod SelectMethod
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

	#endregion DinhMucGioChuanToiThieuTheoChucVuDataSourceActionList
	
	#endregion DinhMucGioChuanToiThieuTheoChucVuDataSourceDesigner
	
	#region DinhMucGioChuanToiThieuTheoChucVuSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DinhMucGioChuanToiThieuTheoChucVuDataSource.SelectMethod property.
	/// </summary>
	public enum DinhMucGioChuanToiThieuTheoChucVuSelectMethod
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
		/// Represents the GetByMaChucVu method.
		/// </summary>
		GetByMaChucVu,
		/// <summary>
		/// Represents the GetByIdQuyMo method.
		/// </summary>
		GetByIdQuyMo,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy,
		/// <summary>
		/// Represents the GetByNamHoc method.
		/// </summary>
		GetByNamHoc
	}
	
	#endregion DinhMucGioChuanToiThieuTheoChucVuSelectMethod

	#region DinhMucGioChuanToiThieuTheoChucVuFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DinhMucGioChuanToiThieuTheoChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DinhMucGioChuanToiThieuTheoChucVuFilter : SqlFilter<DinhMucGioChuanToiThieuTheoChucVuColumn>
	{
	}
	
	#endregion DinhMucGioChuanToiThieuTheoChucVuFilter

	#region DinhMucGioChuanToiThieuTheoChucVuExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DinhMucGioChuanToiThieuTheoChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DinhMucGioChuanToiThieuTheoChucVuExpressionBuilder : SqlExpressionBuilder<DinhMucGioChuanToiThieuTheoChucVuColumn>
	{
	}
	
	#endregion DinhMucGioChuanToiThieuTheoChucVuExpressionBuilder	

	#region DinhMucGioChuanToiThieuTheoChucVuProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DinhMucGioChuanToiThieuTheoChucVuChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DinhMucGioChuanToiThieuTheoChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DinhMucGioChuanToiThieuTheoChucVuProperty : ChildEntityProperty<DinhMucGioChuanToiThieuTheoChucVuChildEntityTypes>
	{
	}
	
	#endregion DinhMucGioChuanToiThieuTheoChucVuProperty
}

