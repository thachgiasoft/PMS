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
	/// Represents the DataRepository.ViewKcqUteKhoiLuongGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKcqUteKhoiLuongGiangDayDataSourceDesigner))]
	public class ViewKcqUteKhoiLuongGiangDayDataSource : ReadOnlyDataSource<ViewKcqUteKhoiLuongGiangDay>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqUteKhoiLuongGiangDayDataSource class.
		/// </summary>
		public ViewKcqUteKhoiLuongGiangDayDataSource() : base(new ViewKcqUteKhoiLuongGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKcqUteKhoiLuongGiangDayDataSourceView used by the ViewKcqUteKhoiLuongGiangDayDataSource.
		/// </summary>
		protected ViewKcqUteKhoiLuongGiangDayDataSourceView ViewKcqUteKhoiLuongGiangDayView
		{
			get { return ( View as ViewKcqUteKhoiLuongGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewKcqUteKhoiLuongGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewKcqUteKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get
			{
				ViewKcqUteKhoiLuongGiangDaySelectMethod selectMethod = ViewKcqUteKhoiLuongGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewKcqUteKhoiLuongGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKcqUteKhoiLuongGiangDayDataSourceView class that is to be
		/// used by the ViewKcqUteKhoiLuongGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKcqUteKhoiLuongGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKcqUteKhoiLuongGiangDay, Object> GetNewDataSourceView()
		{
			return new ViewKcqUteKhoiLuongGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKcqUteKhoiLuongGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKcqUteKhoiLuongGiangDayDataSourceView : ReadOnlyDataSourceView<ViewKcqUteKhoiLuongGiangDay>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqUteKhoiLuongGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKcqUteKhoiLuongGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKcqUteKhoiLuongGiangDayDataSourceView(ViewKcqUteKhoiLuongGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKcqUteKhoiLuongGiangDayDataSource ViewKcqUteKhoiLuongGiangDayOwner
		{
			get { return Owner as ViewKcqUteKhoiLuongGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewKcqUteKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return ViewKcqUteKhoiLuongGiangDayOwner.SelectMethod; }
			set { ViewKcqUteKhoiLuongGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKcqUteKhoiLuongGiangDayService ViewKcqUteKhoiLuongGiangDayProvider
		{
			get { return Provider as ViewKcqUteKhoiLuongGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewKcqUteKhoiLuongGiangDay> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewKcqUteKhoiLuongGiangDay> results = null;
			// ViewKcqUteKhoiLuongGiangDay item;
			count = 0;
			
			System.String sp995_NamHoc;
			System.String sp995_HocKy;
			System.String sp995_Dot;
			System.String sp994_NamHoc;
			System.String sp994_HocKy;

			switch ( SelectMethod )
			{
				case ViewKcqUteKhoiLuongGiangDaySelectMethod.Get:
					results = ViewKcqUteKhoiLuongGiangDayProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewKcqUteKhoiLuongGiangDaySelectMethod.GetPaged:
					results = ViewKcqUteKhoiLuongGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewKcqUteKhoiLuongGiangDaySelectMethod.GetAll:
					results = ViewKcqUteKhoiLuongGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewKcqUteKhoiLuongGiangDaySelectMethod.Find:
					results = ViewKcqUteKhoiLuongGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewKcqUteKhoiLuongGiangDaySelectMethod.GetByNamHocHocKyDot:
					sp995_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp995_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp995_Dot = (System.String) EntityUtil.ChangeType(values["Dot"], typeof(System.String));
					results = ViewKcqUteKhoiLuongGiangDayProvider.GetByNamHocHocKyDot(sp995_NamHoc, sp995_HocKy, sp995_Dot, StartIndex, PageSize);
					break;
				case ViewKcqUteKhoiLuongGiangDaySelectMethod.GetByNamHocHocKy:
					sp994_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp994_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewKcqUteKhoiLuongGiangDayProvider.GetByNamHocHocKy(sp994_NamHoc, sp994_HocKy, StartIndex, PageSize);
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

	#region ViewKcqUteKhoiLuongGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewKcqUteKhoiLuongGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum ViewKcqUteKhoiLuongGiangDaySelectMethod
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
		/// Represents the GetByNamHocHocKyDot method.
		/// </summary>
		GetByNamHocHocKyDot,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion ViewKcqUteKhoiLuongGiangDaySelectMethod
	
	#region ViewKcqUteKhoiLuongGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKcqUteKhoiLuongGiangDayDataSource class.
	/// </summary>
	public class ViewKcqUteKhoiLuongGiangDayDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKcqUteKhoiLuongGiangDay>
	{
		/// <summary>
		/// Initializes a new instance of the ViewKcqUteKhoiLuongGiangDayDataSourceDesigner class.
		/// </summary>
		public ViewKcqUteKhoiLuongGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewKcqUteKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return ((ViewKcqUteKhoiLuongGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewKcqUteKhoiLuongGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewKcqUteKhoiLuongGiangDayDataSourceActionList

	/// <summary>
	/// Supports the ViewKcqUteKhoiLuongGiangDayDataSourceDesigner class.
	/// </summary>
	internal class ViewKcqUteKhoiLuongGiangDayDataSourceActionList : DesignerActionList
	{
		private ViewKcqUteKhoiLuongGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewKcqUteKhoiLuongGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewKcqUteKhoiLuongGiangDayDataSourceActionList(ViewKcqUteKhoiLuongGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewKcqUteKhoiLuongGiangDaySelectMethod SelectMethod
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

	#endregion ViewKcqUteKhoiLuongGiangDayDataSourceActionList

	#endregion ViewKcqUteKhoiLuongGiangDayDataSourceDesigner

	#region ViewKcqUteKhoiLuongGiangDayFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqUteKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqUteKhoiLuongGiangDayFilter : SqlFilter<ViewKcqUteKhoiLuongGiangDayColumn>
	{
	}

	#endregion ViewKcqUteKhoiLuongGiangDayFilter

	#region ViewKcqUteKhoiLuongGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqUteKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqUteKhoiLuongGiangDayExpressionBuilder : SqlExpressionBuilder<ViewKcqUteKhoiLuongGiangDayColumn>
	{
	}
	
	#endregion ViewKcqUteKhoiLuongGiangDayExpressionBuilder		
}

