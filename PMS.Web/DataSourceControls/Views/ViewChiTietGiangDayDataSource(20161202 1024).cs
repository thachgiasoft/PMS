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
	/// Represents the DataRepository.ViewChiTietGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewChiTietGiangDayDataSourceDesigner))]
	public class ViewChiTietGiangDayDataSource : ReadOnlyDataSource<ViewChiTietGiangDay>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietGiangDayDataSource class.
		/// </summary>
		public ViewChiTietGiangDayDataSource() : base(new ViewChiTietGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewChiTietGiangDayDataSourceView used by the ViewChiTietGiangDayDataSource.
		/// </summary>
		protected ViewChiTietGiangDayDataSourceView ViewChiTietGiangDayView
		{
			get { return ( View as ViewChiTietGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewChiTietGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewChiTietGiangDaySelectMethod SelectMethod
		{
			get
			{
				ViewChiTietGiangDaySelectMethod selectMethod = ViewChiTietGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewChiTietGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewChiTietGiangDayDataSourceView class that is to be
		/// used by the ViewChiTietGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the ViewChiTietGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewChiTietGiangDay, Object> GetNewDataSourceView()
		{
			return new ViewChiTietGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewChiTietGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewChiTietGiangDayDataSourceView : ReadOnlyDataSourceView<ViewChiTietGiangDay>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewChiTietGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewChiTietGiangDayDataSourceView(ViewChiTietGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewChiTietGiangDayDataSource ViewChiTietGiangDayOwner
		{
			get { return Owner as ViewChiTietGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewChiTietGiangDaySelectMethod SelectMethod
		{
			get { return ViewChiTietGiangDayOwner.SelectMethod; }
			set { ViewChiTietGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewChiTietGiangDayService ViewChiTietGiangDayProvider
		{
			get { return Provider as ViewChiTietGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewChiTietGiangDay> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewChiTietGiangDay> results = null;
			// ViewChiTietGiangDay item;
			count = 0;
			
			System.String sp3032_MaGiangVien;
			System.String sp3032_MaLopHocPhan;
			System.String sp3032_MaKhoaHoc;

			switch ( SelectMethod )
			{
				case ViewChiTietGiangDaySelectMethod.Get:
					results = ViewChiTietGiangDayProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewChiTietGiangDaySelectMethod.GetPaged:
					results = ViewChiTietGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewChiTietGiangDaySelectMethod.GetAll:
					results = ViewChiTietGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewChiTietGiangDaySelectMethod.Find:
					results = ViewChiTietGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewChiTietGiangDaySelectMethod.GetByMaGiangVienMaLopHocPhanMaKhoaHoc:
					sp3032_MaGiangVien = (System.String) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.String));
					sp3032_MaLopHocPhan = (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String));
					sp3032_MaKhoaHoc = (System.String) EntityUtil.ChangeType(values["MaKhoaHoc"], typeof(System.String));
					results = ViewChiTietGiangDayProvider.GetByMaGiangVienMaLopHocPhanMaKhoaHoc(sp3032_MaGiangVien, sp3032_MaLopHocPhan, sp3032_MaKhoaHoc, StartIndex, PageSize);
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

	#region ViewChiTietGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewChiTietGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum ViewChiTietGiangDaySelectMethod
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
		/// Represents the GetByMaGiangVienMaLopHocPhanMaKhoaHoc method.
		/// </summary>
		GetByMaGiangVienMaLopHocPhanMaKhoaHoc
	}
	
	#endregion ViewChiTietGiangDaySelectMethod
	
	#region ViewChiTietGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewChiTietGiangDayDataSource class.
	/// </summary>
	public class ViewChiTietGiangDayDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewChiTietGiangDay>
	{
		/// <summary>
		/// Initializes a new instance of the ViewChiTietGiangDayDataSourceDesigner class.
		/// </summary>
		public ViewChiTietGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewChiTietGiangDaySelectMethod SelectMethod
		{
			get { return ((ViewChiTietGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewChiTietGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewChiTietGiangDayDataSourceActionList

	/// <summary>
	/// Supports the ViewChiTietGiangDayDataSourceDesigner class.
	/// </summary>
	internal class ViewChiTietGiangDayDataSourceActionList : DesignerActionList
	{
		private ViewChiTietGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewChiTietGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewChiTietGiangDayDataSourceActionList(ViewChiTietGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewChiTietGiangDaySelectMethod SelectMethod
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

	#endregion ViewChiTietGiangDayDataSourceActionList

	#endregion ViewChiTietGiangDayDataSourceDesigner

	#region ViewChiTietGiangDayFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietGiangDayFilter : SqlFilter<ViewChiTietGiangDayColumn>
	{
	}

	#endregion ViewChiTietGiangDayFilter

	#region ViewChiTietGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietGiangDayExpressionBuilder : SqlExpressionBuilder<ViewChiTietGiangDayColumn>
	{
	}
	
	#endregion ViewChiTietGiangDayExpressionBuilder		
}
