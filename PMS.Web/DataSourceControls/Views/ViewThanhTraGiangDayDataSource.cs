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
	/// Represents the DataRepository.ViewThanhTraGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewThanhTraGiangDayDataSourceDesigner))]
	public class ViewThanhTraGiangDayDataSource : ReadOnlyDataSource<ViewThanhTraGiangDay>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraGiangDayDataSource class.
		/// </summary>
		public ViewThanhTraGiangDayDataSource() : base(new ViewThanhTraGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewThanhTraGiangDayDataSourceView used by the ViewThanhTraGiangDayDataSource.
		/// </summary>
		protected ViewThanhTraGiangDayDataSourceView ViewThanhTraGiangDayView
		{
			get { return ( View as ViewThanhTraGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewThanhTraGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewThanhTraGiangDaySelectMethod SelectMethod
		{
			get
			{
				ViewThanhTraGiangDaySelectMethod selectMethod = ViewThanhTraGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewThanhTraGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewThanhTraGiangDayDataSourceView class that is to be
		/// used by the ViewThanhTraGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the ViewThanhTraGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewThanhTraGiangDay, Object> GetNewDataSourceView()
		{
			return new ViewThanhTraGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewThanhTraGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewThanhTraGiangDayDataSourceView : ReadOnlyDataSourceView<ViewThanhTraGiangDay>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewThanhTraGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewThanhTraGiangDayDataSourceView(ViewThanhTraGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewThanhTraGiangDayDataSource ViewThanhTraGiangDayOwner
		{
			get { return Owner as ViewThanhTraGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewThanhTraGiangDaySelectMethod SelectMethod
		{
			get { return ViewThanhTraGiangDayOwner.SelectMethod; }
			set { ViewThanhTraGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewThanhTraGiangDayService ViewThanhTraGiangDayProvider
		{
			get { return Provider as ViewThanhTraGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewThanhTraGiangDay> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewThanhTraGiangDay> results = null;
			// ViewThanhTraGiangDay item;
			count = 0;
			
			System.DateTime sp1091_TuNgay;
			System.DateTime sp1091_DenNgay;
			System.String sp1091_MaBoMon;

			switch ( SelectMethod )
			{
				case ViewThanhTraGiangDaySelectMethod.Get:
					results = ViewThanhTraGiangDayProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewThanhTraGiangDaySelectMethod.GetPaged:
					results = ViewThanhTraGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewThanhTraGiangDaySelectMethod.GetAll:
					results = ViewThanhTraGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewThanhTraGiangDaySelectMethod.Find:
					results = ViewThanhTraGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewThanhTraGiangDaySelectMethod.GetByTuNgayDenNgayMaDonVi:
					sp1091_TuNgay = (System.DateTime) EntityUtil.ChangeType(values["TuNgay"], typeof(System.DateTime));
					sp1091_DenNgay = (System.DateTime) EntityUtil.ChangeType(values["DenNgay"], typeof(System.DateTime));
					sp1091_MaBoMon = (System.String) EntityUtil.ChangeType(values["MaBoMon"], typeof(System.String));
					results = ViewThanhTraGiangDayProvider.GetByTuNgayDenNgayMaDonVi(sp1091_TuNgay, sp1091_DenNgay, sp1091_MaBoMon, StartIndex, PageSize);
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

	#region ViewThanhTraGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewThanhTraGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum ViewThanhTraGiangDaySelectMethod
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
		/// Represents the GetByTuNgayDenNgayMaDonVi method.
		/// </summary>
		GetByTuNgayDenNgayMaDonVi
	}
	
	#endregion ViewThanhTraGiangDaySelectMethod
	
	#region ViewThanhTraGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewThanhTraGiangDayDataSource class.
	/// </summary>
	public class ViewThanhTraGiangDayDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewThanhTraGiangDay>
	{
		/// <summary>
		/// Initializes a new instance of the ViewThanhTraGiangDayDataSourceDesigner class.
		/// </summary>
		public ViewThanhTraGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewThanhTraGiangDaySelectMethod SelectMethod
		{
			get { return ((ViewThanhTraGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewThanhTraGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewThanhTraGiangDayDataSourceActionList

	/// <summary>
	/// Supports the ViewThanhTraGiangDayDataSourceDesigner class.
	/// </summary>
	internal class ViewThanhTraGiangDayDataSourceActionList : DesignerActionList
	{
		private ViewThanhTraGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewThanhTraGiangDayDataSourceActionList(ViewThanhTraGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewThanhTraGiangDaySelectMethod SelectMethod
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

	#endregion ViewThanhTraGiangDayDataSourceActionList

	#endregion ViewThanhTraGiangDayDataSourceDesigner

	#region ViewThanhTraGiangDayFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhTraGiangDayFilter : SqlFilter<ViewThanhTraGiangDayColumn>
	{
	}

	#endregion ViewThanhTraGiangDayFilter

	#region ViewThanhTraGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhTraGiangDayExpressionBuilder : SqlExpressionBuilder<ViewThanhTraGiangDayColumn>
	{
	}
	
	#endregion ViewThanhTraGiangDayExpressionBuilder		
}

