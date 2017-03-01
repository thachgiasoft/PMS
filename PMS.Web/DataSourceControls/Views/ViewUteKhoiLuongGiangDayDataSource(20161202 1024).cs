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
	/// Represents the DataRepository.ViewUteKhoiLuongGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewUteKhoiLuongGiangDayDataSourceDesigner))]
	public class ViewUteKhoiLuongGiangDayDataSource : ReadOnlyDataSource<ViewUteKhoiLuongGiangDay>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongGiangDayDataSource class.
		/// </summary>
		public ViewUteKhoiLuongGiangDayDataSource() : base(new ViewUteKhoiLuongGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewUteKhoiLuongGiangDayDataSourceView used by the ViewUteKhoiLuongGiangDayDataSource.
		/// </summary>
		protected ViewUteKhoiLuongGiangDayDataSourceView ViewUteKhoiLuongGiangDayView
		{
			get { return ( View as ViewUteKhoiLuongGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewUteKhoiLuongGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewUteKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get
			{
				ViewUteKhoiLuongGiangDaySelectMethod selectMethod = ViewUteKhoiLuongGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewUteKhoiLuongGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewUteKhoiLuongGiangDayDataSourceView class that is to be
		/// used by the ViewUteKhoiLuongGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the ViewUteKhoiLuongGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewUteKhoiLuongGiangDay, Object> GetNewDataSourceView()
		{
			return new ViewUteKhoiLuongGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewUteKhoiLuongGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewUteKhoiLuongGiangDayDataSourceView : ReadOnlyDataSourceView<ViewUteKhoiLuongGiangDay>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewUteKhoiLuongGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewUteKhoiLuongGiangDayDataSourceView(ViewUteKhoiLuongGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewUteKhoiLuongGiangDayDataSource ViewUteKhoiLuongGiangDayOwner
		{
			get { return Owner as ViewUteKhoiLuongGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewUteKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return ViewUteKhoiLuongGiangDayOwner.SelectMethod; }
			set { ViewUteKhoiLuongGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewUteKhoiLuongGiangDayService ViewUteKhoiLuongGiangDayProvider
		{
			get { return Provider as ViewUteKhoiLuongGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewUteKhoiLuongGiangDay> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewUteKhoiLuongGiangDay> results = null;
			// ViewUteKhoiLuongGiangDay item;
			count = 0;
			
			System.String sp3232_NamHoc;
			System.String sp3232_HocKy;

			switch ( SelectMethod )
			{
				case ViewUteKhoiLuongGiangDaySelectMethod.Get:
					results = ViewUteKhoiLuongGiangDayProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewUteKhoiLuongGiangDaySelectMethod.GetPaged:
					results = ViewUteKhoiLuongGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewUteKhoiLuongGiangDaySelectMethod.GetAll:
					results = ViewUteKhoiLuongGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewUteKhoiLuongGiangDaySelectMethod.Find:
					results = ViewUteKhoiLuongGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewUteKhoiLuongGiangDaySelectMethod.GetByNamHocHocKy:
					sp3232_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3232_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewUteKhoiLuongGiangDayProvider.GetByNamHocHocKy(sp3232_NamHoc, sp3232_HocKy, StartIndex, PageSize);
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

	#region ViewUteKhoiLuongGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewUteKhoiLuongGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum ViewUteKhoiLuongGiangDaySelectMethod
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
		GetByNamHocHocKy
	}
	
	#endregion ViewUteKhoiLuongGiangDaySelectMethod
	
	#region ViewUteKhoiLuongGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewUteKhoiLuongGiangDayDataSource class.
	/// </summary>
	public class ViewUteKhoiLuongGiangDayDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewUteKhoiLuongGiangDay>
	{
		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongGiangDayDataSourceDesigner class.
		/// </summary>
		public ViewUteKhoiLuongGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewUteKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return ((ViewUteKhoiLuongGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewUteKhoiLuongGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewUteKhoiLuongGiangDayDataSourceActionList

	/// <summary>
	/// Supports the ViewUteKhoiLuongGiangDayDataSourceDesigner class.
	/// </summary>
	internal class ViewUteKhoiLuongGiangDayDataSourceActionList : DesignerActionList
	{
		private ViewUteKhoiLuongGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewUteKhoiLuongGiangDayDataSourceActionList(ViewUteKhoiLuongGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewUteKhoiLuongGiangDaySelectMethod SelectMethod
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

	#endregion ViewUteKhoiLuongGiangDayDataSourceActionList

	#endregion ViewUteKhoiLuongGiangDayDataSourceDesigner

	#region ViewUteKhoiLuongGiangDayFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewUteKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewUteKhoiLuongGiangDayFilter : SqlFilter<ViewUteKhoiLuongGiangDayColumn>
	{
	}

	#endregion ViewUteKhoiLuongGiangDayFilter

	#region ViewUteKhoiLuongGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewUteKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewUteKhoiLuongGiangDayExpressionBuilder : SqlExpressionBuilder<ViewUteKhoiLuongGiangDayColumn>
	{
	}
	
	#endregion ViewUteKhoiLuongGiangDayExpressionBuilder		
}

