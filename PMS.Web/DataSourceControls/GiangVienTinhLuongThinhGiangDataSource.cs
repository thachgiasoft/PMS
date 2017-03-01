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
	/// Represents the DataRepository.GiangVienTinhLuongThinhGiangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienTinhLuongThinhGiangDataSourceDesigner))]
	public class GiangVienTinhLuongThinhGiangDataSource : ProviderDataSource<GiangVienTinhLuongThinhGiang, GiangVienTinhLuongThinhGiangKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienTinhLuongThinhGiangDataSource class.
		/// </summary>
		public GiangVienTinhLuongThinhGiangDataSource() : base(new GiangVienTinhLuongThinhGiangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienTinhLuongThinhGiangDataSourceView used by the GiangVienTinhLuongThinhGiangDataSource.
		/// </summary>
		protected GiangVienTinhLuongThinhGiangDataSourceView GiangVienTinhLuongThinhGiangView
		{
			get { return ( View as GiangVienTinhLuongThinhGiangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienTinhLuongThinhGiangDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienTinhLuongThinhGiangSelectMethod SelectMethod
		{
			get
			{
				GiangVienTinhLuongThinhGiangSelectMethod selectMethod = GiangVienTinhLuongThinhGiangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienTinhLuongThinhGiangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienTinhLuongThinhGiangDataSourceView class that is to be
		/// used by the GiangVienTinhLuongThinhGiangDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienTinhLuongThinhGiangDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienTinhLuongThinhGiang, GiangVienTinhLuongThinhGiangKey> GetNewDataSourceView()
		{
			return new GiangVienTinhLuongThinhGiangDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienTinhLuongThinhGiangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienTinhLuongThinhGiangDataSourceView : ProviderDataSourceView<GiangVienTinhLuongThinhGiang, GiangVienTinhLuongThinhGiangKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienTinhLuongThinhGiangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienTinhLuongThinhGiangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienTinhLuongThinhGiangDataSourceView(GiangVienTinhLuongThinhGiangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienTinhLuongThinhGiangDataSource GiangVienTinhLuongThinhGiangOwner
		{
			get { return Owner as GiangVienTinhLuongThinhGiangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienTinhLuongThinhGiangSelectMethod SelectMethod
		{
			get { return GiangVienTinhLuongThinhGiangOwner.SelectMethod; }
			set { GiangVienTinhLuongThinhGiangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienTinhLuongThinhGiangService GiangVienTinhLuongThinhGiangProvider
		{
			get { return Provider as GiangVienTinhLuongThinhGiangService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienTinhLuongThinhGiang> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienTinhLuongThinhGiang> results = null;
			GiangVienTinhLuongThinhGiang item;
			count = 0;
			
			System.Int32 _maGiangVien;
			System.String _namHoc;
			System.String _hocKy;
			System.Int32 _maCauHinhChotGio;
			System.String _maMonHoc;
			System.String _maLopSinhVien;

			switch ( SelectMethod )
			{
				case GiangVienTinhLuongThinhGiangSelectMethod.Get:
					GiangVienTinhLuongThinhGiangKey entityKey  = new GiangVienTinhLuongThinhGiangKey();
					entityKey.Load(values);
					item = GiangVienTinhLuongThinhGiangProvider.Get(entityKey);
					results = new TList<GiangVienTinhLuongThinhGiang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienTinhLuongThinhGiangSelectMethod.GetAll:
                    results = GiangVienTinhLuongThinhGiangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienTinhLuongThinhGiangSelectMethod.GetPaged:
					results = GiangVienTinhLuongThinhGiangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienTinhLuongThinhGiangSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienTinhLuongThinhGiangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienTinhLuongThinhGiangProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienTinhLuongThinhGiangSelectMethod.GetByMaGiangVienNamHocHocKyMaCauHinhChotGioMaMonHocMaLopSinhVien:
					_maGiangVien = ( values["MaGiangVien"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32)) : (int)0;
					_namHoc = ( values["NamHoc"] != null ) ? (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String)) : string.Empty;
					_hocKy = ( values["HocKy"] != null ) ? (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String)) : string.Empty;
					_maCauHinhChotGio = ( values["MaCauHinhChotGio"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaCauHinhChotGio"], typeof(System.Int32)) : (int)0;
					_maMonHoc = ( values["MaMonHoc"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaMonHoc"], typeof(System.String)) : string.Empty;
					_maLopSinhVien = ( values["MaLopSinhVien"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLopSinhVien"], typeof(System.String)) : string.Empty;
					item = GiangVienTinhLuongThinhGiangProvider.GetByMaGiangVienNamHocHocKyMaCauHinhChotGioMaMonHocMaLopSinhVien(_maGiangVien, _namHoc, _hocKy, _maCauHinhChotGio, _maMonHoc, _maLopSinhVien);
					results = new TList<GiangVienTinhLuongThinhGiang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case GiangVienTinhLuongThinhGiangSelectMethod.GetByMaGiangVien:
					_maGiangVien = ( values["MaGiangVien"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32)) : (int)0;
					results = GiangVienTinhLuongThinhGiangProvider.GetByMaGiangVien(_maGiangVien, this.StartIndex, this.PageSize, out count);
					break;
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
			if ( SelectMethod == GiangVienTinhLuongThinhGiangSelectMethod.Get || SelectMethod == GiangVienTinhLuongThinhGiangSelectMethod.GetByMaGiangVienNamHocHocKyMaCauHinhChotGioMaMonHocMaLopSinhVien )
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
				GiangVienTinhLuongThinhGiang entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienTinhLuongThinhGiangProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienTinhLuongThinhGiang> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienTinhLuongThinhGiangProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienTinhLuongThinhGiangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienTinhLuongThinhGiangDataSource class.
	/// </summary>
	public class GiangVienTinhLuongThinhGiangDataSourceDesigner : ProviderDataSourceDesigner<GiangVienTinhLuongThinhGiang, GiangVienTinhLuongThinhGiangKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienTinhLuongThinhGiangDataSourceDesigner class.
		/// </summary>
		public GiangVienTinhLuongThinhGiangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienTinhLuongThinhGiangSelectMethod SelectMethod
		{
			get { return ((GiangVienTinhLuongThinhGiangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienTinhLuongThinhGiangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienTinhLuongThinhGiangDataSourceActionList

	/// <summary>
	/// Supports the GiangVienTinhLuongThinhGiangDataSourceDesigner class.
	/// </summary>
	internal class GiangVienTinhLuongThinhGiangDataSourceActionList : DesignerActionList
	{
		private GiangVienTinhLuongThinhGiangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienTinhLuongThinhGiangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienTinhLuongThinhGiangDataSourceActionList(GiangVienTinhLuongThinhGiangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienTinhLuongThinhGiangSelectMethod SelectMethod
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

	#endregion GiangVienTinhLuongThinhGiangDataSourceActionList
	
	#endregion GiangVienTinhLuongThinhGiangDataSourceDesigner
	
	#region GiangVienTinhLuongThinhGiangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienTinhLuongThinhGiangDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienTinhLuongThinhGiangSelectMethod
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
		/// Represents the GetByMaGiangVienNamHocHocKyMaCauHinhChotGioMaMonHocMaLopSinhVien method.
		/// </summary>
		GetByMaGiangVienNamHocHocKyMaCauHinhChotGioMaMonHocMaLopSinhVien,
		/// <summary>
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien
	}
	
	#endregion GiangVienTinhLuongThinhGiangSelectMethod

	#region GiangVienTinhLuongThinhGiangFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTinhLuongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienTinhLuongThinhGiangFilter : SqlFilter<GiangVienTinhLuongThinhGiangColumn>
	{
	}
	
	#endregion GiangVienTinhLuongThinhGiangFilter

	#region GiangVienTinhLuongThinhGiangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTinhLuongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienTinhLuongThinhGiangExpressionBuilder : SqlExpressionBuilder<GiangVienTinhLuongThinhGiangColumn>
	{
	}
	
	#endregion GiangVienTinhLuongThinhGiangExpressionBuilder	

	#region GiangVienTinhLuongThinhGiangProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienTinhLuongThinhGiangChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTinhLuongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienTinhLuongThinhGiangProperty : ChildEntityProperty<GiangVienTinhLuongThinhGiangChildEntityTypes>
	{
	}
	
	#endregion GiangVienTinhLuongThinhGiangProperty
}

