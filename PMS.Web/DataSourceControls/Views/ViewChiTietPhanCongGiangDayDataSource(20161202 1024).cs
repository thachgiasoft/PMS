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
	/// Represents the DataRepository.ViewChiTietPhanCongGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewChiTietPhanCongGiangDayDataSourceDesigner))]
	public class ViewChiTietPhanCongGiangDayDataSource : ReadOnlyDataSource<ViewChiTietPhanCongGiangDay>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietPhanCongGiangDayDataSource class.
		/// </summary>
		public ViewChiTietPhanCongGiangDayDataSource() : base(new ViewChiTietPhanCongGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewChiTietPhanCongGiangDayDataSourceView used by the ViewChiTietPhanCongGiangDayDataSource.
		/// </summary>
		protected ViewChiTietPhanCongGiangDayDataSourceView ViewChiTietPhanCongGiangDayView
		{
			get { return ( View as ViewChiTietPhanCongGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewChiTietPhanCongGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewChiTietPhanCongGiangDaySelectMethod SelectMethod
		{
			get
			{
				ViewChiTietPhanCongGiangDaySelectMethod selectMethod = ViewChiTietPhanCongGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewChiTietPhanCongGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewChiTietPhanCongGiangDayDataSourceView class that is to be
		/// used by the ViewChiTietPhanCongGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the ViewChiTietPhanCongGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewChiTietPhanCongGiangDay, Object> GetNewDataSourceView()
		{
			return new ViewChiTietPhanCongGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewChiTietPhanCongGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewChiTietPhanCongGiangDayDataSourceView : ReadOnlyDataSourceView<ViewChiTietPhanCongGiangDay>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietPhanCongGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewChiTietPhanCongGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewChiTietPhanCongGiangDayDataSourceView(ViewChiTietPhanCongGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewChiTietPhanCongGiangDayDataSource ViewChiTietPhanCongGiangDayOwner
		{
			get { return Owner as ViewChiTietPhanCongGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewChiTietPhanCongGiangDaySelectMethod SelectMethod
		{
			get { return ViewChiTietPhanCongGiangDayOwner.SelectMethod; }
			set { ViewChiTietPhanCongGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewChiTietPhanCongGiangDayService ViewChiTietPhanCongGiangDayProvider
		{
			get { return Provider as ViewChiTietPhanCongGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewChiTietPhanCongGiangDay> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewChiTietPhanCongGiangDay> results = null;
			// ViewChiTietPhanCongGiangDay item;
			count = 0;
			
			System.String sp3038_MaLopHocPhan;

			switch ( SelectMethod )
			{
				case ViewChiTietPhanCongGiangDaySelectMethod.Get:
					results = ViewChiTietPhanCongGiangDayProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewChiTietPhanCongGiangDaySelectMethod.GetPaged:
					results = ViewChiTietPhanCongGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewChiTietPhanCongGiangDaySelectMethod.GetAll:
					results = ViewChiTietPhanCongGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewChiTietPhanCongGiangDaySelectMethod.Find:
					results = ViewChiTietPhanCongGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewChiTietPhanCongGiangDaySelectMethod.GetByMaLopHocPhan:
					sp3038_MaLopHocPhan = (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String));
					results = ViewChiTietPhanCongGiangDayProvider.GetByMaLopHocPhan(sp3038_MaLopHocPhan, StartIndex, PageSize);
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

	#region ViewChiTietPhanCongGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewChiTietPhanCongGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum ViewChiTietPhanCongGiangDaySelectMethod
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
		/// Represents the GetByMaLopHocPhan method.
		/// </summary>
		GetByMaLopHocPhan
	}
	
	#endregion ViewChiTietPhanCongGiangDaySelectMethod
	
	#region ViewChiTietPhanCongGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewChiTietPhanCongGiangDayDataSource class.
	/// </summary>
	public class ViewChiTietPhanCongGiangDayDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewChiTietPhanCongGiangDay>
	{
		/// <summary>
		/// Initializes a new instance of the ViewChiTietPhanCongGiangDayDataSourceDesigner class.
		/// </summary>
		public ViewChiTietPhanCongGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewChiTietPhanCongGiangDaySelectMethod SelectMethod
		{
			get { return ((ViewChiTietPhanCongGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewChiTietPhanCongGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewChiTietPhanCongGiangDayDataSourceActionList

	/// <summary>
	/// Supports the ViewChiTietPhanCongGiangDayDataSourceDesigner class.
	/// </summary>
	internal class ViewChiTietPhanCongGiangDayDataSourceActionList : DesignerActionList
	{
		private ViewChiTietPhanCongGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewChiTietPhanCongGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewChiTietPhanCongGiangDayDataSourceActionList(ViewChiTietPhanCongGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewChiTietPhanCongGiangDaySelectMethod SelectMethod
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

	#endregion ViewChiTietPhanCongGiangDayDataSourceActionList

	#endregion ViewChiTietPhanCongGiangDayDataSourceDesigner

	#region ViewChiTietPhanCongGiangDayFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietPhanCongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietPhanCongGiangDayFilter : SqlFilter<ViewChiTietPhanCongGiangDayColumn>
	{
	}

	#endregion ViewChiTietPhanCongGiangDayFilter

	#region ViewChiTietPhanCongGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietPhanCongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietPhanCongGiangDayExpressionBuilder : SqlExpressionBuilder<ViewChiTietPhanCongGiangDayColumn>
	{
	}
	
	#endregion ViewChiTietPhanCongGiangDayExpressionBuilder		
}
