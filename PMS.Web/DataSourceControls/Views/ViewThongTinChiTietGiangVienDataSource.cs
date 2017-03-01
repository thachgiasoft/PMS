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
	/// Represents the DataRepository.ViewThongTinChiTietGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewThongTinChiTietGiangVienDataSourceDesigner))]
	public class ViewThongTinChiTietGiangVienDataSource : ReadOnlyDataSource<ViewThongTinChiTietGiangVien>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinChiTietGiangVienDataSource class.
		/// </summary>
		public ViewThongTinChiTietGiangVienDataSource() : base(new ViewThongTinChiTietGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewThongTinChiTietGiangVienDataSourceView used by the ViewThongTinChiTietGiangVienDataSource.
		/// </summary>
		protected ViewThongTinChiTietGiangVienDataSourceView ViewThongTinChiTietGiangVienView
		{
			get { return ( View as ViewThongTinChiTietGiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewThongTinChiTietGiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewThongTinChiTietGiangVienSelectMethod SelectMethod
		{
			get
			{
				ViewThongTinChiTietGiangVienSelectMethod selectMethod = ViewThongTinChiTietGiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewThongTinChiTietGiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewThongTinChiTietGiangVienDataSourceView class that is to be
		/// used by the ViewThongTinChiTietGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the ViewThongTinChiTietGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewThongTinChiTietGiangVien, Object> GetNewDataSourceView()
		{
			return new ViewThongTinChiTietGiangVienDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewThongTinChiTietGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewThongTinChiTietGiangVienDataSourceView : ReadOnlyDataSourceView<ViewThongTinChiTietGiangVien>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongTinChiTietGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewThongTinChiTietGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewThongTinChiTietGiangVienDataSourceView(ViewThongTinChiTietGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewThongTinChiTietGiangVienDataSource ViewThongTinChiTietGiangVienOwner
		{
			get { return Owner as ViewThongTinChiTietGiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewThongTinChiTietGiangVienSelectMethod SelectMethod
		{
			get { return ViewThongTinChiTietGiangVienOwner.SelectMethod; }
			set { ViewThongTinChiTietGiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewThongTinChiTietGiangVienService ViewThongTinChiTietGiangVienProvider
		{
			get { return Provider as ViewThongTinChiTietGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewThongTinChiTietGiangVien> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewThongTinChiTietGiangVien> results = null;
			// ViewThongTinChiTietGiangVien item;
			count = 0;
			
			System.String sp1113_MaDonVi;
			System.Int32 sp1113_MaHocHam;
			System.Int32 sp1113_MaHocVi;
			System.String sp1113_MaTinhTrang;

			switch ( SelectMethod )
			{
				case ViewThongTinChiTietGiangVienSelectMethod.Get:
					results = ViewThongTinChiTietGiangVienProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewThongTinChiTietGiangVienSelectMethod.GetPaged:
					results = ViewThongTinChiTietGiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewThongTinChiTietGiangVienSelectMethod.GetAll:
					results = ViewThongTinChiTietGiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewThongTinChiTietGiangVienSelectMethod.Find:
					results = ViewThongTinChiTietGiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewThongTinChiTietGiangVienSelectMethod.GetByMaDonViMaHocHamMaHocViMaTinhTrang:
					sp1113_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					sp1113_MaHocHam = (System.Int32) EntityUtil.ChangeType(values["MaHocHam"], typeof(System.Int32));
					sp1113_MaHocVi = (System.Int32) EntityUtil.ChangeType(values["MaHocVi"], typeof(System.Int32));
					sp1113_MaTinhTrang = (System.String) EntityUtil.ChangeType(values["MaTinhTrang"], typeof(System.String));
					results = ViewThongTinChiTietGiangVienProvider.GetByMaDonViMaHocHamMaHocViMaTinhTrang(sp1113_MaDonVi, sp1113_MaHocHam, sp1113_MaHocVi, sp1113_MaTinhTrang, StartIndex, PageSize);
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

	#region ViewThongTinChiTietGiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewThongTinChiTietGiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum ViewThongTinChiTietGiangVienSelectMethod
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
	
	#endregion ViewThongTinChiTietGiangVienSelectMethod
	
	#region ViewThongTinChiTietGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewThongTinChiTietGiangVienDataSource class.
	/// </summary>
	public class ViewThongTinChiTietGiangVienDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewThongTinChiTietGiangVien>
	{
		/// <summary>
		/// Initializes a new instance of the ViewThongTinChiTietGiangVienDataSourceDesigner class.
		/// </summary>
		public ViewThongTinChiTietGiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewThongTinChiTietGiangVienSelectMethod SelectMethod
		{
			get { return ((ViewThongTinChiTietGiangVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewThongTinChiTietGiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewThongTinChiTietGiangVienDataSourceActionList

	/// <summary>
	/// Supports the ViewThongTinChiTietGiangVienDataSourceDesigner class.
	/// </summary>
	internal class ViewThongTinChiTietGiangVienDataSourceActionList : DesignerActionList
	{
		private ViewThongTinChiTietGiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewThongTinChiTietGiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewThongTinChiTietGiangVienDataSourceActionList(ViewThongTinChiTietGiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewThongTinChiTietGiangVienSelectMethod SelectMethod
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

	#endregion ViewThongTinChiTietGiangVienDataSourceActionList

	#endregion ViewThongTinChiTietGiangVienDataSourceDesigner

	#region ViewThongTinChiTietGiangVienFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinChiTietGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongTinChiTietGiangVienFilter : SqlFilter<ViewThongTinChiTietGiangVienColumn>
	{
	}

	#endregion ViewThongTinChiTietGiangVienFilter

	#region ViewThongTinChiTietGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongTinChiTietGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongTinChiTietGiangVienExpressionBuilder : SqlExpressionBuilder<ViewThongTinChiTietGiangVienColumn>
	{
	}
	
	#endregion ViewThongTinChiTietGiangVienExpressionBuilder		
}

