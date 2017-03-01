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
	/// Represents the DataRepository.QuyDoiGioChuanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(QuyDoiGioChuanDataSourceDesigner))]
	public class QuyDoiGioChuanDataSource : ProviderDataSource<QuyDoiGioChuan, QuyDoiGioChuanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDoiGioChuanDataSource class.
		/// </summary>
		public QuyDoiGioChuanDataSource() : base(new QuyDoiGioChuanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the QuyDoiGioChuanDataSourceView used by the QuyDoiGioChuanDataSource.
		/// </summary>
		protected QuyDoiGioChuanDataSourceView QuyDoiGioChuanView
		{
			get { return ( View as QuyDoiGioChuanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the QuyDoiGioChuanDataSource control invokes to retrieve data.
		/// </summary>
		public QuyDoiGioChuanSelectMethod SelectMethod
		{
			get
			{
				QuyDoiGioChuanSelectMethod selectMethod = QuyDoiGioChuanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (QuyDoiGioChuanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the QuyDoiGioChuanDataSourceView class that is to be
		/// used by the QuyDoiGioChuanDataSource.
		/// </summary>
		/// <returns>An instance of the QuyDoiGioChuanDataSourceView class.</returns>
		protected override BaseDataSourceView<QuyDoiGioChuan, QuyDoiGioChuanKey> GetNewDataSourceView()
		{
			return new QuyDoiGioChuanDataSourceView(this, DefaultViewName);
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
	/// Supports the QuyDoiGioChuanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class QuyDoiGioChuanDataSourceView : ProviderDataSourceView<QuyDoiGioChuan, QuyDoiGioChuanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDoiGioChuanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the QuyDoiGioChuanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public QuyDoiGioChuanDataSourceView(QuyDoiGioChuanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal QuyDoiGioChuanDataSource QuyDoiGioChuanOwner
		{
			get { return Owner as QuyDoiGioChuanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal QuyDoiGioChuanSelectMethod SelectMethod
		{
			get { return QuyDoiGioChuanOwner.SelectMethod; }
			set { QuyDoiGioChuanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal QuyDoiGioChuanService QuyDoiGioChuanProvider
		{
			get { return Provider as QuyDoiGioChuanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<QuyDoiGioChuan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<QuyDoiGioChuan> results = null;
			QuyDoiGioChuan item;
			count = 0;
			
			System.Int32 _maQuyDoi;
			System.Int32? _maDonVi_nullable;
			System.String _maLoaiKhoiLuong_nullable;
			System.String sp2803_MaLoaiKhoiLuong;
			System.String sp2803_NamHoc;
			System.String sp2803_HocKy;
			System.String sp2804_NamHoc;
			System.String sp2804_HocKy;
			System.String sp2805_NamHoc;
			System.String sp2805_HocKy;

			switch ( SelectMethod )
			{
				case QuyDoiGioChuanSelectMethod.Get:
					QuyDoiGioChuanKey entityKey  = new QuyDoiGioChuanKey();
					entityKey.Load(values);
					item = QuyDoiGioChuanProvider.Get(entityKey);
					results = new TList<QuyDoiGioChuan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case QuyDoiGioChuanSelectMethod.GetAll:
                    results = QuyDoiGioChuanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case QuyDoiGioChuanSelectMethod.GetPaged:
					results = QuyDoiGioChuanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case QuyDoiGioChuanSelectMethod.Find:
					if ( FilterParameters != null )
						results = QuyDoiGioChuanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = QuyDoiGioChuanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case QuyDoiGioChuanSelectMethod.GetByMaQuyDoi:
					_maQuyDoi = ( values["MaQuyDoi"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaQuyDoi"], typeof(System.Int32)) : (int)0;
					item = QuyDoiGioChuanProvider.GetByMaQuyDoi(_maQuyDoi);
					results = new TList<QuyDoiGioChuan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case QuyDoiGioChuanSelectMethod.GetByMaDonVi:
					_maDonVi_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.Int32?));
					results = QuyDoiGioChuanProvider.GetByMaDonVi(_maDonVi_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case QuyDoiGioChuanSelectMethod.GetByMaLoaiKhoiLuong:
					_maLoaiKhoiLuong_nullable = (System.String) EntityUtil.ChangeType(values["MaLoaiKhoiLuong"], typeof(System.String));
					results = QuyDoiGioChuanProvider.GetByMaLoaiKhoiLuong(_maLoaiKhoiLuong_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				case QuyDoiGioChuanSelectMethod.GetByMaLoaiKhoiLuongNamHocHocKy:
					sp2803_MaLoaiKhoiLuong = (System.String) EntityUtil.ChangeType(values["MaLoaiKhoiLuong"], typeof(System.String));
					sp2803_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2803_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = QuyDoiGioChuanProvider.GetByMaLoaiKhoiLuongNamHocHocKy(sp2803_MaLoaiKhoiLuong, sp2803_NamHoc, sp2803_HocKy, StartIndex, PageSize);
					break;
				case QuyDoiGioChuanSelectMethod.GetByNamHocHocKy:
					sp2804_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2804_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = QuyDoiGioChuanProvider.GetByNamHocHocKy(sp2804_NamHoc, sp2804_HocKy, StartIndex, PageSize);
					break;
				case QuyDoiGioChuanSelectMethod.GetByNamHocHocKyKlk:
					sp2805_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2805_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = QuyDoiGioChuanProvider.GetByNamHocHocKyKlk(sp2805_NamHoc, sp2805_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == QuyDoiGioChuanSelectMethod.Get || SelectMethod == QuyDoiGioChuanSelectMethod.GetByMaQuyDoi )
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
				QuyDoiGioChuan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					QuyDoiGioChuanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<QuyDoiGioChuan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			QuyDoiGioChuanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region QuyDoiGioChuanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the QuyDoiGioChuanDataSource class.
	/// </summary>
	public class QuyDoiGioChuanDataSourceDesigner : ProviderDataSourceDesigner<QuyDoiGioChuan, QuyDoiGioChuanKey>
	{
		/// <summary>
		/// Initializes a new instance of the QuyDoiGioChuanDataSourceDesigner class.
		/// </summary>
		public QuyDoiGioChuanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public QuyDoiGioChuanSelectMethod SelectMethod
		{
			get { return ((QuyDoiGioChuanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new QuyDoiGioChuanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region QuyDoiGioChuanDataSourceActionList

	/// <summary>
	/// Supports the QuyDoiGioChuanDataSourceDesigner class.
	/// </summary>
	internal class QuyDoiGioChuanDataSourceActionList : DesignerActionList
	{
		private QuyDoiGioChuanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the QuyDoiGioChuanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public QuyDoiGioChuanDataSourceActionList(QuyDoiGioChuanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public QuyDoiGioChuanSelectMethod SelectMethod
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

	#endregion QuyDoiGioChuanDataSourceActionList
	
	#endregion QuyDoiGioChuanDataSourceDesigner
	
	#region QuyDoiGioChuanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the QuyDoiGioChuanDataSource.SelectMethod property.
	/// </summary>
	public enum QuyDoiGioChuanSelectMethod
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
		/// Represents the GetByMaQuyDoi method.
		/// </summary>
		GetByMaQuyDoi,
		/// <summary>
		/// Represents the GetByMaDonVi method.
		/// </summary>
		GetByMaDonVi,
		/// <summary>
		/// Represents the GetByMaLoaiKhoiLuong method.
		/// </summary>
		GetByMaLoaiKhoiLuong,
		/// <summary>
		/// Represents the GetByMaLoaiKhoiLuongNamHocHocKy method.
		/// </summary>
		GetByMaLoaiKhoiLuongNamHocHocKy,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy,
		/// <summary>
		/// Represents the GetByNamHocHocKyKlk method.
		/// </summary>
		GetByNamHocHocKyKlk
	}
	
	#endregion QuyDoiGioChuanSelectMethod

	#region QuyDoiGioChuanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDoiGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDoiGioChuanFilter : SqlFilter<QuyDoiGioChuanColumn>
	{
	}
	
	#endregion QuyDoiGioChuanFilter

	#region QuyDoiGioChuanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDoiGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDoiGioChuanExpressionBuilder : SqlExpressionBuilder<QuyDoiGioChuanColumn>
	{
	}
	
	#endregion QuyDoiGioChuanExpressionBuilder	

	#region QuyDoiGioChuanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;QuyDoiGioChuanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDoiGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDoiGioChuanProperty : ChildEntityProperty<QuyDoiGioChuanChildEntityTypes>
	{
	}
	
	#endregion QuyDoiGioChuanProperty
}

