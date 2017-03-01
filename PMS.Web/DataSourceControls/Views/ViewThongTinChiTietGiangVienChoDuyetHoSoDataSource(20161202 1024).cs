#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.ViewThongTinChiTietGiangVienChoDuyetHoSoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceDesigner))]
	public class ViewThongTinChiTietGiangVienChoDuyetHoSoDataSource : ReadOnlyDataSource<ViewThongTinChiTietGiangVienChoDuyetHoSo>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinChiTietGiangVienChoDuyetHoSoDataSource class.
		/// </summary>
		public ViewThongTinChiTietGiangVienChoDuyetHoSoDataSource() : base(new ViewThongTinChiTietGiangVienChoDuyetHoSoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceView used by the ViewThongTinChiTietGiangVienChoDuyetHoSoDataSource.
		/// </summary>
		protected ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceView ViewThongTinChiTietGiangVienChoDuyetHoSoView
		{
			get { return ( View as ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewThongTinChiTietGiangVienChoDuyetHoSoDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewThongTinChiTietGiangVienChoDuyetHoSoSelectMethod SelectMethod
		{
			get
			{
				ViewThongTinChiTietGiangVienChoDuyetHoSoSelectMethod selectMethod = ViewThongTinChiTietGiangVienChoDuyetHoSoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewThongTinChiTietGiangVienChoDuyetHoSoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceView class that is to be
		/// used by the ViewThongTinChiTietGiangVienChoDuyetHoSoDataSource.
		/// </summary>
		/// <returns>An instance of the ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewThongTinChiTietGiangVienChoDuyetHoSo, Object> GetNewDataSourceView()
		{
			return new ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewThongTinChiTietGiangVienChoDuyetHoSoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceView : ReadOnlyDataSourceView<ViewThongTinChiTietGiangVienChoDuyetHoSo>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewThongTinChiTietGiangVienChoDuyetHoSoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceView(ViewThongTinChiTietGiangVienChoDuyetHoSoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewThongTinChiTietGiangVienChoDuyetHoSoDataSource ViewThongTinChiTietGiangVienChoDuyetHoSoOwner
		{
			get { return Owner as ViewThongTinChiTietGiangVienChoDuyetHoSoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewThongTinChiTietGiangVienChoDuyetHoSoSelectMethod SelectMethod
		{
			get { return ViewThongTinChiTietGiangVienChoDuyetHoSoOwner.SelectMethod; }
			set { ViewThongTinChiTietGiangVienChoDuyetHoSoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewThongTinChiTietGiangVienChoDuyetHoSoService ViewThongTinChiTietGiangVienChoDuyetHoSoProvider
		{
			get { return Provider as ViewThongTinChiTietGiangVienChoDuyetHoSoService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewThongTinChiTietGiangVienChoDuyetHoSo> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewThongTinChiTietGiangVienChoDuyetHoSo> results = null;
			// ViewThongTinChiTietGiangVienChoDuyetHoSo item;
			count = 0;
			
			System.String sp3211_MaDonVi;
			System.Int32 sp3211_MaHocHam;
			System.Int32 sp3211_MaHocVi;
			System.String sp3211_MaTinhTrang;

			switch ( SelectMethod )
			{
				case ViewThongTinChiTietGiangVienChoDuyetHoSoSelectMethod.Get:
					results = ViewThongTinChiTietGiangVienChoDuyetHoSoProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewThongTinChiTietGiangVienChoDuyetHoSoSelectMethod.GetPaged:
					results = ViewThongTinChiTietGiangVienChoDuyetHoSoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewThongTinChiTietGiangVienChoDuyetHoSoSelectMethod.GetAll:
					results = ViewThongTinChiTietGiangVienChoDuyetHoSoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewThongTinChiTietGiangVienChoDuyetHoSoSelectMethod.Find:
					results = ViewThongTinChiTietGiangVienChoDuyetHoSoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewThongTinChiTietGiangVienChoDuyetHoSoSelectMethod.GetByMaDonViMaHocHamMaHocViMaTinhTrang:
					sp3211_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					sp3211_MaHocHam = (System.Int32) EntityUtil.ChangeType(values["MaHocHam"], typeof(System.Int32));
					sp3211_MaHocVi = (System.Int32) EntityUtil.ChangeType(values["MaHocVi"], typeof(System.Int32));
					sp3211_MaTinhTrang = (System.String) EntityUtil.ChangeType(values["MaTinhTrang"], typeof(System.String));
					results = ViewThongTinChiTietGiangVienChoDuyetHoSoProvider.GetByMaDonViMaHocHamMaHocViMaTinhTrang(sp3211_MaDonVi, sp3211_MaHocHam, sp3211_MaHocVi, sp3211_MaTinhTrang, StartIndex, PageSize);
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
		
		#endregion Methods
	}

	#region ViewThongTinChiTietGiangVienChoDuyetHoSoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewThongTinChiTietGiangVienChoDuyetHoSoDataSource.SelectMethod property.
	/// </summary>
	public enum ViewThongTinChiTietGiangVienChoDuyetHoSoSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByMaDonViMaHocHamMaHocViMaTinhTrang method.
		/// </summary>
		GetByMaDonViMaHocHamMaHocViMaTinhTrang
	}
	
	#endregion ViewThongTinChiTietGiangVienChoDuyetHoSoSelectMethod
	
	#region ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewThongTinChiTietGiangVienChoDuyetHoSoDataSource class.
	/// </summary>
	public class ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewThongTinChiTietGiangVienChoDuyetHoSo>
	{
		/// <summary>
		/// Initializes a new instance of the ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceDesigner class.
		/// </summary>
		public ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewThongTinChiTietGiangVienChoDuyetHoSoSelectMethod SelectMethod
		{
			get { return ((ViewThongTinChiTietGiangVienChoDuyetHoSoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceActionList

	/// <summary>
	/// Supports the ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceDesigner class.
	/// </summary>
	internal class ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceActionList : DesignerActionList
	{
		private ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceActionList(ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewThongTinChiTietGiangVienChoDuyetHoSoSelectMethod SelectMethod
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

	#endregion ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceActionList

	#endregion ViewThongTinChiTietGiangVienChoDuyetHoSoDataSourceDesigner

	#region ViewThongTinChiTietGiangVienChoDuyetHoSoFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinChiTietGiangVienChoDuyetHoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongTinChiTietGiangVienChoDuyetHoSoFilter : SqlFilter<ViewThongTinChiTietGiangVienChoDuyetHoSoColumn>
	{
	}

	#endregion ViewThongTinChiTietGiangVienChoDuyetHoSoFilter

	#region ViewThongTinChiTietGiangVienChoDuyetHoSoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinChiTietGiangVienChoDuyetHoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongTinChiTietGiangVienChoDuyetHoSoExpressionBuilder : SqlExpressionBuilder<ViewThongTinChiTietGiangVienChoDuyetHoSoColumn>
	{
	}
	
	#endregion ViewThongTinChiTietGiangVienChoDuyetHoSoExpressionBuilder		
}

