﻿#region Using Directives
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
	/// Represents the DataRepository.ViewTinhKhoiLuongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewTinhKhoiLuongDataSourceDesigner))]
	public class ViewTinhKhoiLuongDataSource : ReadOnlyDataSource<ViewTinhKhoiLuong>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongDataSource class.
		/// </summary>
		public ViewTinhKhoiLuongDataSource() : base(new ViewTinhKhoiLuongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewTinhKhoiLuongDataSourceView used by the ViewTinhKhoiLuongDataSource.
		/// </summary>
		protected ViewTinhKhoiLuongDataSourceView ViewTinhKhoiLuongView
		{
			get { return ( View as ViewTinhKhoiLuongDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewTinhKhoiLuongDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewTinhKhoiLuongSelectMethod SelectMethod
		{
			get
			{
				ViewTinhKhoiLuongSelectMethod selectMethod = ViewTinhKhoiLuongSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewTinhKhoiLuongSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewTinhKhoiLuongDataSourceView class that is to be
		/// used by the ViewTinhKhoiLuongDataSource.
		/// </summary>
		/// <returns>An instance of the ViewTinhKhoiLuongDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewTinhKhoiLuong, Object> GetNewDataSourceView()
		{
			return new ViewTinhKhoiLuongDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewTinhKhoiLuongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewTinhKhoiLuongDataSourceView : ReadOnlyDataSourceView<ViewTinhKhoiLuong>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewTinhKhoiLuongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewTinhKhoiLuongDataSourceView(ViewTinhKhoiLuongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewTinhKhoiLuongDataSource ViewTinhKhoiLuongOwner
		{
			get { return Owner as ViewTinhKhoiLuongDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewTinhKhoiLuongSelectMethod SelectMethod
		{
			get { return ViewTinhKhoiLuongOwner.SelectMethod; }
			set { ViewTinhKhoiLuongOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewTinhKhoiLuongService ViewTinhKhoiLuongProvider
		{
			get { return Provider as ViewTinhKhoiLuongService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewTinhKhoiLuong> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewTinhKhoiLuong> results = null;
			// ViewTinhKhoiLuong item;
			count = 0;
			
			System.String sp3224_NamHoc;
			System.String sp3224_HocKy;
			System.Int32 sp3224_MaGiangVien;
			System.String sp3223_NamHoc;
			System.String sp3223_HocKy;

			switch ( SelectMethod )
			{
				case ViewTinhKhoiLuongSelectMethod.Get:
					results = ViewTinhKhoiLuongProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewTinhKhoiLuongSelectMethod.GetPaged:
					results = ViewTinhKhoiLuongProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewTinhKhoiLuongSelectMethod.GetAll:
					results = ViewTinhKhoiLuongProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewTinhKhoiLuongSelectMethod.Find:
					results = ViewTinhKhoiLuongProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewTinhKhoiLuongSelectMethod.GetByNamHocHocKyMaGiangVien:
					sp3224_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3224_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp3224_MaGiangVien = (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32));
					results = ViewTinhKhoiLuongProvider.GetByNamHocHocKyMaGiangVien(sp3224_NamHoc, sp3224_HocKy, sp3224_MaGiangVien, StartIndex, PageSize);
					break;
				case ViewTinhKhoiLuongSelectMethod.GetByNamHocHocKy:
					sp3223_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3223_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewTinhKhoiLuongProvider.GetByNamHocHocKy(sp3223_NamHoc, sp3223_HocKy, StartIndex, PageSize);
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

	#region ViewTinhKhoiLuongSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewTinhKhoiLuongDataSource.SelectMethod property.
	/// </summary>
	public enum ViewTinhKhoiLuongSelectMethod
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
		/// Represents the GetByNamHocHocKyMaGiangVien method.
		/// </summary>
		GetByNamHocHocKyMaGiangVien,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion ViewTinhKhoiLuongSelectMethod
	
	#region ViewTinhKhoiLuongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewTinhKhoiLuongDataSource class.
	/// </summary>
	public class ViewTinhKhoiLuongDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewTinhKhoiLuong>
	{
		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongDataSourceDesigner class.
		/// </summary>
		public ViewTinhKhoiLuongDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewTinhKhoiLuongSelectMethod SelectMethod
		{
			get { return ((ViewTinhKhoiLuongDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewTinhKhoiLuongDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewTinhKhoiLuongDataSourceActionList

	/// <summary>
	/// Supports the ViewTinhKhoiLuongDataSourceDesigner class.
	/// </summary>
	internal class ViewTinhKhoiLuongDataSourceActionList : DesignerActionList
	{
		private ViewTinhKhoiLuongDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewTinhKhoiLuongDataSourceActionList(ViewTinhKhoiLuongDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewTinhKhoiLuongSelectMethod SelectMethod
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

	#endregion ViewTinhKhoiLuongDataSourceActionList

	#endregion ViewTinhKhoiLuongDataSourceDesigner

	#region ViewTinhKhoiLuongFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTinhKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTinhKhoiLuongFilter : SqlFilter<ViewTinhKhoiLuongColumn>
	{
	}

	#endregion ViewTinhKhoiLuongFilter

	#region ViewTinhKhoiLuongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTinhKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTinhKhoiLuongExpressionBuilder : SqlExpressionBuilder<ViewTinhKhoiLuongColumn>
	{
	}
	
	#endregion ViewTinhKhoiLuongExpressionBuilder		
}
