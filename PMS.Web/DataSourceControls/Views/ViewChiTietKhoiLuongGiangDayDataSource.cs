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
	/// Represents the DataRepository.ViewChiTietKhoiLuongGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewChiTietKhoiLuongGiangDayDataSourceDesigner))]
	public class ViewChiTietKhoiLuongGiangDayDataSource : ReadOnlyDataSource<ViewChiTietKhoiLuongGiangDay>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongGiangDayDataSource class.
		/// </summary>
		public ViewChiTietKhoiLuongGiangDayDataSource() : base(new ViewChiTietKhoiLuongGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewChiTietKhoiLuongGiangDayDataSourceView used by the ViewChiTietKhoiLuongGiangDayDataSource.
		/// </summary>
		protected ViewChiTietKhoiLuongGiangDayDataSourceView ViewChiTietKhoiLuongGiangDayView
		{
			get { return ( View as ViewChiTietKhoiLuongGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewChiTietKhoiLuongGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewChiTietKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get
			{
				ViewChiTietKhoiLuongGiangDaySelectMethod selectMethod = ViewChiTietKhoiLuongGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewChiTietKhoiLuongGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewChiTietKhoiLuongGiangDayDataSourceView class that is to be
		/// used by the ViewChiTietKhoiLuongGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the ViewChiTietKhoiLuongGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewChiTietKhoiLuongGiangDay, Object> GetNewDataSourceView()
		{
			return new ViewChiTietKhoiLuongGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewChiTietKhoiLuongGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewChiTietKhoiLuongGiangDayDataSourceView : ReadOnlyDataSourceView<ViewChiTietKhoiLuongGiangDay>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewChiTietKhoiLuongGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewChiTietKhoiLuongGiangDayDataSourceView(ViewChiTietKhoiLuongGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewChiTietKhoiLuongGiangDayDataSource ViewChiTietKhoiLuongGiangDayOwner
		{
			get { return Owner as ViewChiTietKhoiLuongGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewChiTietKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return ViewChiTietKhoiLuongGiangDayOwner.SelectMethod; }
			set { ViewChiTietKhoiLuongGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewChiTietKhoiLuongGiangDayService ViewChiTietKhoiLuongGiangDayProvider
		{
			get { return Provider as ViewChiTietKhoiLuongGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewChiTietKhoiLuongGiangDay> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewChiTietKhoiLuongGiangDay> results = null;
			// ViewChiTietKhoiLuongGiangDay item;
			count = 0;
			
			System.String sp939_NamHoc;
			System.String sp939_HocKy;

			switch ( SelectMethod )
			{
				case ViewChiTietKhoiLuongGiangDaySelectMethod.Get:
					results = ViewChiTietKhoiLuongGiangDayProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewChiTietKhoiLuongGiangDaySelectMethod.GetPaged:
					results = ViewChiTietKhoiLuongGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewChiTietKhoiLuongGiangDaySelectMethod.GetAll:
					results = ViewChiTietKhoiLuongGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewChiTietKhoiLuongGiangDaySelectMethod.Find:
					results = ViewChiTietKhoiLuongGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewChiTietKhoiLuongGiangDaySelectMethod.GetByNamHocHocKy:
					sp939_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp939_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewChiTietKhoiLuongGiangDayProvider.GetByNamHocHocKy(sp939_NamHoc, sp939_HocKy, StartIndex, PageSize);
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

	#region ViewChiTietKhoiLuongGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewChiTietKhoiLuongGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum ViewChiTietKhoiLuongGiangDaySelectMethod
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
	
	#endregion ViewChiTietKhoiLuongGiangDaySelectMethod
	
	#region ViewChiTietKhoiLuongGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewChiTietKhoiLuongGiangDayDataSource class.
	/// </summary>
	public class ViewChiTietKhoiLuongGiangDayDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewChiTietKhoiLuongGiangDay>
	{
		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongGiangDayDataSourceDesigner class.
		/// </summary>
		public ViewChiTietKhoiLuongGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewChiTietKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return ((ViewChiTietKhoiLuongGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewChiTietKhoiLuongGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewChiTietKhoiLuongGiangDayDataSourceActionList

	/// <summary>
	/// Supports the ViewChiTietKhoiLuongGiangDayDataSourceDesigner class.
	/// </summary>
	internal class ViewChiTietKhoiLuongGiangDayDataSourceActionList : DesignerActionList
	{
		private ViewChiTietKhoiLuongGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewChiTietKhoiLuongGiangDayDataSourceActionList(ViewChiTietKhoiLuongGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewChiTietKhoiLuongGiangDaySelectMethod SelectMethod
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

	#endregion ViewChiTietKhoiLuongGiangDayDataSourceActionList

	#endregion ViewChiTietKhoiLuongGiangDayDataSourceDesigner

	#region ViewChiTietKhoiLuongGiangDayFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietKhoiLuongGiangDayFilter : SqlFilter<ViewChiTietKhoiLuongGiangDayColumn>
	{
	}

	#endregion ViewChiTietKhoiLuongGiangDayFilter

	#region ViewChiTietKhoiLuongGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietKhoiLuongGiangDayExpressionBuilder : SqlExpressionBuilder<ViewChiTietKhoiLuongGiangDayColumn>
	{
	}
	
	#endregion ViewChiTietKhoiLuongGiangDayExpressionBuilder		
}

