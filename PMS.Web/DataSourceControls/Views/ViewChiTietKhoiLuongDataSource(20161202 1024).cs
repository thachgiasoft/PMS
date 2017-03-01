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
	/// Represents the DataRepository.ViewChiTietKhoiLuongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewChiTietKhoiLuongDataSourceDesigner))]
	public class ViewChiTietKhoiLuongDataSource : ReadOnlyDataSource<ViewChiTietKhoiLuong>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongDataSource class.
		/// </summary>
		public ViewChiTietKhoiLuongDataSource() : base(new ViewChiTietKhoiLuongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewChiTietKhoiLuongDataSourceView used by the ViewChiTietKhoiLuongDataSource.
		/// </summary>
		protected ViewChiTietKhoiLuongDataSourceView ViewChiTietKhoiLuongView
		{
			get { return ( View as ViewChiTietKhoiLuongDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewChiTietKhoiLuongDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewChiTietKhoiLuongSelectMethod SelectMethod
		{
			get
			{
				ViewChiTietKhoiLuongSelectMethod selectMethod = ViewChiTietKhoiLuongSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewChiTietKhoiLuongSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewChiTietKhoiLuongDataSourceView class that is to be
		/// used by the ViewChiTietKhoiLuongDataSource.
		/// </summary>
		/// <returns>An instance of the ViewChiTietKhoiLuongDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewChiTietKhoiLuong, Object> GetNewDataSourceView()
		{
			return new ViewChiTietKhoiLuongDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewChiTietKhoiLuongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewChiTietKhoiLuongDataSourceView : ReadOnlyDataSourceView<ViewChiTietKhoiLuong>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewChiTietKhoiLuongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewChiTietKhoiLuongDataSourceView(ViewChiTietKhoiLuongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewChiTietKhoiLuongDataSource ViewChiTietKhoiLuongOwner
		{
			get { return Owner as ViewChiTietKhoiLuongDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewChiTietKhoiLuongSelectMethod SelectMethod
		{
			get { return ViewChiTietKhoiLuongOwner.SelectMethod; }
			set { ViewChiTietKhoiLuongOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewChiTietKhoiLuongService ViewChiTietKhoiLuongProvider
		{
			get { return Provider as ViewChiTietKhoiLuongService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewChiTietKhoiLuong> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewChiTietKhoiLuong> results = null;
			// ViewChiTietKhoiLuong item;
			count = 0;
			
			System.String sp3035_NamHoc;
			System.String sp3035_HocKy;
			System.String sp3035_MaBoMon;
			System.Int32 sp3035_MaGiangVien;

			switch ( SelectMethod )
			{
				case ViewChiTietKhoiLuongSelectMethod.Get:
					results = ViewChiTietKhoiLuongProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewChiTietKhoiLuongSelectMethod.GetPaged:
					results = ViewChiTietKhoiLuongProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewChiTietKhoiLuongSelectMethod.GetAll:
					results = ViewChiTietKhoiLuongProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewChiTietKhoiLuongSelectMethod.Find:
					results = ViewChiTietKhoiLuongProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewChiTietKhoiLuongSelectMethod.GetByNamHocHocKyMaDonViMaGiangVien:
					sp3035_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3035_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp3035_MaBoMon = (System.String) EntityUtil.ChangeType(values["MaBoMon"], typeof(System.String));
					sp3035_MaGiangVien = (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32));
					results = ViewChiTietKhoiLuongProvider.GetByNamHocHocKyMaDonViMaGiangVien(sp3035_NamHoc, sp3035_HocKy, sp3035_MaBoMon, sp3035_MaGiangVien, StartIndex, PageSize);
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

	#region ViewChiTietKhoiLuongSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewChiTietKhoiLuongDataSource.SelectMethod property.
	/// </summary>
	public enum ViewChiTietKhoiLuongSelectMethod
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
		/// Represents the GetByNamHocHocKyMaDonViMaGiangVien method.
		/// </summary>
		GetByNamHocHocKyMaDonViMaGiangVien
	}
	
	#endregion ViewChiTietKhoiLuongSelectMethod
	
	#region ViewChiTietKhoiLuongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewChiTietKhoiLuongDataSource class.
	/// </summary>
	public class ViewChiTietKhoiLuongDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewChiTietKhoiLuong>
	{
		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongDataSourceDesigner class.
		/// </summary>
		public ViewChiTietKhoiLuongDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewChiTietKhoiLuongSelectMethod SelectMethod
		{
			get { return ((ViewChiTietKhoiLuongDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewChiTietKhoiLuongDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewChiTietKhoiLuongDataSourceActionList

	/// <summary>
	/// Supports the ViewChiTietKhoiLuongDataSourceDesigner class.
	/// </summary>
	internal class ViewChiTietKhoiLuongDataSourceActionList : DesignerActionList
	{
		private ViewChiTietKhoiLuongDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewChiTietKhoiLuongDataSourceActionList(ViewChiTietKhoiLuongDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewChiTietKhoiLuongSelectMethod SelectMethod
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

	#endregion ViewChiTietKhoiLuongDataSourceActionList

	#endregion ViewChiTietKhoiLuongDataSourceDesigner

	#region ViewChiTietKhoiLuongFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietKhoiLuongFilter : SqlFilter<ViewChiTietKhoiLuongColumn>
	{
	}

	#endregion ViewChiTietKhoiLuongFilter

	#region ViewChiTietKhoiLuongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietKhoiLuongExpressionBuilder : SqlExpressionBuilder<ViewChiTietKhoiLuongColumn>
	{
	}
	
	#endregion ViewChiTietKhoiLuongExpressionBuilder		
}

