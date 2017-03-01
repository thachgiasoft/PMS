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
	/// Represents the DataRepository.DonGiaTcbProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DonGiaTcbDataSourceDesigner))]
	public class DonGiaTcbDataSource : ProviderDataSource<DonGiaTcb, DonGiaTcbKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaTcbDataSource class.
		/// </summary>
		public DonGiaTcbDataSource() : base(new DonGiaTcbService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DonGiaTcbDataSourceView used by the DonGiaTcbDataSource.
		/// </summary>
		protected DonGiaTcbDataSourceView DonGiaTcbView
		{
			get { return ( View as DonGiaTcbDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DonGiaTcbDataSource control invokes to retrieve data.
		/// </summary>
		public DonGiaTcbSelectMethod SelectMethod
		{
			get
			{
				DonGiaTcbSelectMethod selectMethod = DonGiaTcbSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DonGiaTcbSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DonGiaTcbDataSourceView class that is to be
		/// used by the DonGiaTcbDataSource.
		/// </summary>
		/// <returns>An instance of the DonGiaTcbDataSourceView class.</returns>
		protected override BaseDataSourceView<DonGiaTcb, DonGiaTcbKey> GetNewDataSourceView()
		{
			return new DonGiaTcbDataSourceView(this, DefaultViewName);
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
	/// Supports the DonGiaTcbDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DonGiaTcbDataSourceView : ProviderDataSourceView<DonGiaTcb, DonGiaTcbKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaTcbDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DonGiaTcbDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DonGiaTcbDataSourceView(DonGiaTcbDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DonGiaTcbDataSource DonGiaTcbOwner
		{
			get { return Owner as DonGiaTcbDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DonGiaTcbSelectMethod SelectMethod
		{
			get { return DonGiaTcbOwner.SelectMethod; }
			set { DonGiaTcbOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DonGiaTcbService DonGiaTcbProvider
		{
			get { return Provider as DonGiaTcbService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DonGiaTcb> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DonGiaTcb> results = null;
			DonGiaTcb item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2184_MaDonGia;
			System.String sp2185_MaGiangVienQuanLy;
			System.String sp2186_MaGiangVienQuanLy;
			System.DateTime sp2186_NgayDay;

			switch ( SelectMethod )
			{
				case DonGiaTcbSelectMethod.Get:
					DonGiaTcbKey entityKey  = new DonGiaTcbKey();
					entityKey.Load(values);
					item = DonGiaTcbProvider.Get(entityKey);
					results = new TList<DonGiaTcb>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DonGiaTcbSelectMethod.GetAll:
                    results = DonGiaTcbProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DonGiaTcbSelectMethod.GetPaged:
					results = DonGiaTcbProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DonGiaTcbSelectMethod.Find:
					if ( FilterParameters != null )
						results = DonGiaTcbProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DonGiaTcbProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DonGiaTcbSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = DonGiaTcbProvider.GetById(_id);
					results = new TList<DonGiaTcb>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case DonGiaTcbSelectMethod.GetByMaDonGia:
					sp2184_MaDonGia = (System.String) EntityUtil.ChangeType(values["MaDonGia"], typeof(System.String));
					results = DonGiaTcbProvider.GetByMaDonGia(sp2184_MaDonGia, StartIndex, PageSize);
					break;
				case DonGiaTcbSelectMethod.GetByMaGiangVienQuanLy:
					sp2185_MaGiangVienQuanLy = (System.String) EntityUtil.ChangeType(values["MaGiangVienQuanLy"], typeof(System.String));
					results = DonGiaTcbProvider.GetByMaGiangVienQuanLy(sp2185_MaGiangVienQuanLy, StartIndex, PageSize);
					break;
				case DonGiaTcbSelectMethod.GetByMaGiangVienQuanLyNgayDay:
					sp2186_MaGiangVienQuanLy = (System.String) EntityUtil.ChangeType(values["MaGiangVienQuanLy"], typeof(System.String));
					sp2186_NgayDay = (System.DateTime) EntityUtil.ChangeType(values["NgayDay"], typeof(System.DateTime));
					results = DonGiaTcbProvider.GetByMaGiangVienQuanLyNgayDay(sp2186_MaGiangVienQuanLy, sp2186_NgayDay, StartIndex, PageSize);
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
			if ( SelectMethod == DonGiaTcbSelectMethod.Get || SelectMethod == DonGiaTcbSelectMethod.GetById )
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
				DonGiaTcb entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DonGiaTcbProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DonGiaTcb> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DonGiaTcbProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DonGiaTcbDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DonGiaTcbDataSource class.
	/// </summary>
	public class DonGiaTcbDataSourceDesigner : ProviderDataSourceDesigner<DonGiaTcb, DonGiaTcbKey>
	{
		/// <summary>
		/// Initializes a new instance of the DonGiaTcbDataSourceDesigner class.
		/// </summary>
		public DonGiaTcbDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DonGiaTcbSelectMethod SelectMethod
		{
			get { return ((DonGiaTcbDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DonGiaTcbDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DonGiaTcbDataSourceActionList

	/// <summary>
	/// Supports the DonGiaTcbDataSourceDesigner class.
	/// </summary>
	internal class DonGiaTcbDataSourceActionList : DesignerActionList
	{
		private DonGiaTcbDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DonGiaTcbDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DonGiaTcbDataSourceActionList(DonGiaTcbDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DonGiaTcbSelectMethod SelectMethod
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

	#endregion DonGiaTcbDataSourceActionList
	
	#endregion DonGiaTcbDataSourceDesigner
	
	#region DonGiaTcbSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DonGiaTcbDataSource.SelectMethod property.
	/// </summary>
	public enum DonGiaTcbSelectMethod
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
		/// Represents the GetByMaDonGia method.
		/// </summary>
		GetByMaDonGia,
		/// <summary>
		/// Represents the GetByMaGiangVienQuanLy method.
		/// </summary>
		GetByMaGiangVienQuanLy,
		/// <summary>
		/// Represents the GetByMaGiangVienQuanLyNgayDay method.
		/// </summary>
		GetByMaGiangVienQuanLyNgayDay
	}
	
	#endregion DonGiaTcbSelectMethod

	#region DonGiaTcbFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaTcb"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaTcbFilter : SqlFilter<DonGiaTcbColumn>
	{
	}
	
	#endregion DonGiaTcbFilter

	#region DonGiaTcbExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaTcb"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaTcbExpressionBuilder : SqlExpressionBuilder<DonGiaTcbColumn>
	{
	}
	
	#endregion DonGiaTcbExpressionBuilder	

	#region DonGiaTcbProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DonGiaTcbChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaTcb"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaTcbProperty : ChildEntityProperty<DonGiaTcbChildEntityTypes>
	{
	}
	
	#endregion DonGiaTcbProperty
}

