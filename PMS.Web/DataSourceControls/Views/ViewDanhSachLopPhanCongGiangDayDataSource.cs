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
	/// Represents the DataRepository.ViewDanhSachLopPhanCongGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewDanhSachLopPhanCongGiangDayDataSourceDesigner))]
	public class ViewDanhSachLopPhanCongGiangDayDataSource : ReadOnlyDataSource<ViewDanhSachLopPhanCongGiangDay>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachLopPhanCongGiangDayDataSource class.
		/// </summary>
		public ViewDanhSachLopPhanCongGiangDayDataSource() : base(new ViewDanhSachLopPhanCongGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewDanhSachLopPhanCongGiangDayDataSourceView used by the ViewDanhSachLopPhanCongGiangDayDataSource.
		/// </summary>
		protected ViewDanhSachLopPhanCongGiangDayDataSourceView ViewDanhSachLopPhanCongGiangDayView
		{
			get { return ( View as ViewDanhSachLopPhanCongGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewDanhSachLopPhanCongGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewDanhSachLopPhanCongGiangDaySelectMethod SelectMethod
		{
			get
			{
				ViewDanhSachLopPhanCongGiangDaySelectMethod selectMethod = ViewDanhSachLopPhanCongGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewDanhSachLopPhanCongGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewDanhSachLopPhanCongGiangDayDataSourceView class that is to be
		/// used by the ViewDanhSachLopPhanCongGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the ViewDanhSachLopPhanCongGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewDanhSachLopPhanCongGiangDay, Object> GetNewDataSourceView()
		{
			return new ViewDanhSachLopPhanCongGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewDanhSachLopPhanCongGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewDanhSachLopPhanCongGiangDayDataSourceView : ReadOnlyDataSourceView<ViewDanhSachLopPhanCongGiangDay>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachLopPhanCongGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewDanhSachLopPhanCongGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewDanhSachLopPhanCongGiangDayDataSourceView(ViewDanhSachLopPhanCongGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewDanhSachLopPhanCongGiangDayDataSource ViewDanhSachLopPhanCongGiangDayOwner
		{
			get { return Owner as ViewDanhSachLopPhanCongGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewDanhSachLopPhanCongGiangDaySelectMethod SelectMethod
		{
			get { return ViewDanhSachLopPhanCongGiangDayOwner.SelectMethod; }
			set { ViewDanhSachLopPhanCongGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewDanhSachLopPhanCongGiangDayService ViewDanhSachLopPhanCongGiangDayProvider
		{
			get { return Provider as ViewDanhSachLopPhanCongGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewDanhSachLopPhanCongGiangDay> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewDanhSachLopPhanCongGiangDay> results = null;
			// ViewDanhSachLopPhanCongGiangDay item;
			count = 0;
			
			System.String sp948_NamHoc;
			System.String sp948_HocKy;
			System.String sp949_NamHoc;
			System.String sp949_HocKy;
			System.String sp949_MaGiangVien;

			switch ( SelectMethod )
			{
				case ViewDanhSachLopPhanCongGiangDaySelectMethod.Get:
					results = ViewDanhSachLopPhanCongGiangDayProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewDanhSachLopPhanCongGiangDaySelectMethod.GetPaged:
					results = ViewDanhSachLopPhanCongGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewDanhSachLopPhanCongGiangDaySelectMethod.GetAll:
					results = ViewDanhSachLopPhanCongGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewDanhSachLopPhanCongGiangDaySelectMethod.Find:
					results = ViewDanhSachLopPhanCongGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewDanhSachLopPhanCongGiangDaySelectMethod.GetByNamHocHocKy:
					sp948_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp948_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewDanhSachLopPhanCongGiangDayProvider.GetByNamHocHocKy(sp948_NamHoc, sp948_HocKy, StartIndex, PageSize);
					break;
				case ViewDanhSachLopPhanCongGiangDaySelectMethod.GetByNamHocHocKyMaGiangVien:
					sp949_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp949_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp949_MaGiangVien = (System.String) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.String));
					results = ViewDanhSachLopPhanCongGiangDayProvider.GetByNamHocHocKyMaGiangVien(sp949_NamHoc, sp949_HocKy, sp949_MaGiangVien, StartIndex, PageSize);
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

	#region ViewDanhSachLopPhanCongGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewDanhSachLopPhanCongGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum ViewDanhSachLopPhanCongGiangDaySelectMethod
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
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy,
		/// <summary>
		/// Represents the GetByNamHocHocKyMaGiangVien method.
		/// </summary>
		GetByNamHocHocKyMaGiangVien
	}
	
	#endregion ViewDanhSachLopPhanCongGiangDaySelectMethod
	
	#region ViewDanhSachLopPhanCongGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewDanhSachLopPhanCongGiangDayDataSource class.
	/// </summary>
	public class ViewDanhSachLopPhanCongGiangDayDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewDanhSachLopPhanCongGiangDay>
	{
		/// <summary>
		/// Initializes a new instance of the ViewDanhSachLopPhanCongGiangDayDataSourceDesigner class.
		/// </summary>
		public ViewDanhSachLopPhanCongGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewDanhSachLopPhanCongGiangDaySelectMethod SelectMethod
		{
			get { return ((ViewDanhSachLopPhanCongGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewDanhSachLopPhanCongGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewDanhSachLopPhanCongGiangDayDataSourceActionList

	/// <summary>
	/// Supports the ViewDanhSachLopPhanCongGiangDayDataSourceDesigner class.
	/// </summary>
	internal class ViewDanhSachLopPhanCongGiangDayDataSourceActionList : DesignerActionList
	{
		private ViewDanhSachLopPhanCongGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachLopPhanCongGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewDanhSachLopPhanCongGiangDayDataSourceActionList(ViewDanhSachLopPhanCongGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewDanhSachLopPhanCongGiangDaySelectMethod SelectMethod
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

	#endregion ViewDanhSachLopPhanCongGiangDayDataSourceActionList

	#endregion ViewDanhSachLopPhanCongGiangDayDataSourceDesigner

	#region ViewDanhSachLopPhanCongGiangDayFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDanhSachLopPhanCongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDanhSachLopPhanCongGiangDayFilter : SqlFilter<ViewDanhSachLopPhanCongGiangDayColumn>
	{
	}

	#endregion ViewDanhSachLopPhanCongGiangDayFilter

	#region ViewDanhSachLopPhanCongGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDanhSachLopPhanCongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDanhSachLopPhanCongGiangDayExpressionBuilder : SqlExpressionBuilder<ViewDanhSachLopPhanCongGiangDayColumn>
	{
	}
	
	#endregion ViewDanhSachLopPhanCongGiangDayExpressionBuilder		
}

