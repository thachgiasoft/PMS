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
	/// Represents the DataRepository.ViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceDesigner))]
	public class ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSource : ReadOnlyDataSource<ViewKcqLietKeKhoiLuongGiangDayChiTiet2>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSource class.
		/// </summary>
		public ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSource() : base(new ViewKcqLietKeKhoiLuongGiangDayChiTiet2Service())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceView used by the ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSource.
		/// </summary>
		protected ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceView ViewKcqLietKeKhoiLuongGiangDayChiTiet2View
		{
			get { return ( View as ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSource control invokes to retrieve data.
		/// </summary>
		public new ViewKcqLietKeKhoiLuongGiangDayChiTiet2SelectMethod SelectMethod
		{
			get
			{
				ViewKcqLietKeKhoiLuongGiangDayChiTiet2SelectMethod selectMethod = ViewKcqLietKeKhoiLuongGiangDayChiTiet2SelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewKcqLietKeKhoiLuongGiangDayChiTiet2SelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceView class that is to be
		/// used by the ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSource.
		/// </summary>
		/// <returns>An instance of the ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKcqLietKeKhoiLuongGiangDayChiTiet2, Object> GetNewDataSourceView()
		{
			return new ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceView : ReadOnlyDataSourceView<ViewKcqLietKeKhoiLuongGiangDayChiTiet2>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceView(ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSource ViewKcqLietKeKhoiLuongGiangDayChiTiet2Owner
		{
			get { return Owner as ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewKcqLietKeKhoiLuongGiangDayChiTiet2SelectMethod SelectMethod
		{
			get { return ViewKcqLietKeKhoiLuongGiangDayChiTiet2Owner.SelectMethod; }
			set { ViewKcqLietKeKhoiLuongGiangDayChiTiet2Owner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKcqLietKeKhoiLuongGiangDayChiTiet2Service ViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider
		{
			get { return Provider as ViewKcqLietKeKhoiLuongGiangDayChiTiet2Service; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewKcqLietKeKhoiLuongGiangDayChiTiet2> results = null;
			// ViewKcqLietKeKhoiLuongGiangDayChiTiet2 item;
			count = 0;
			
			System.String sp987_NamHoc;
			System.String sp987_HocKy;

			switch ( SelectMethod )
			{
				case ViewKcqLietKeKhoiLuongGiangDayChiTiet2SelectMethod.Get:
					results = ViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewKcqLietKeKhoiLuongGiangDayChiTiet2SelectMethod.GetPaged:
					results = ViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewKcqLietKeKhoiLuongGiangDayChiTiet2SelectMethod.GetAll:
					results = ViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewKcqLietKeKhoiLuongGiangDayChiTiet2SelectMethod.Find:
					results = ViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewKcqLietKeKhoiLuongGiangDayChiTiet2SelectMethod.GetByNamHocHocKy:
					sp987_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp987_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider.GetByNamHocHocKy(sp987_NamHoc, sp987_HocKy, StartIndex, PageSize);
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

	#region ViewKcqLietKeKhoiLuongGiangDayChiTiet2SelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSource.SelectMethod property.
	/// </summary>
	public enum ViewKcqLietKeKhoiLuongGiangDayChiTiet2SelectMethod
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
	
	#endregion ViewKcqLietKeKhoiLuongGiangDayChiTiet2SelectMethod
	
	#region ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSource class.
	/// </summary>
	public class ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKcqLietKeKhoiLuongGiangDayChiTiet2>
	{
		/// <summary>
		/// Initializes a new instance of the ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceDesigner class.
		/// </summary>
		public ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewKcqLietKeKhoiLuongGiangDayChiTiet2SelectMethod SelectMethod
		{
			get { return ((ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceActionList

	/// <summary>
	/// Supports the ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceDesigner class.
	/// </summary>
	internal class ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceActionList : DesignerActionList
	{
		private ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceActionList(ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewKcqLietKeKhoiLuongGiangDayChiTiet2SelectMethod SelectMethod
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

	#endregion ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceActionList

	#endregion ViewKcqLietKeKhoiLuongGiangDayChiTiet2DataSourceDesigner

	#region ViewKcqLietKeKhoiLuongGiangDayChiTiet2Filter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqLietKeKhoiLuongGiangDayChiTiet2"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqLietKeKhoiLuongGiangDayChiTiet2Filter : SqlFilter<ViewKcqLietKeKhoiLuongGiangDayChiTiet2Column>
	{
	}

	#endregion ViewKcqLietKeKhoiLuongGiangDayChiTiet2Filter

	#region ViewKcqLietKeKhoiLuongGiangDayChiTiet2ExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqLietKeKhoiLuongGiangDayChiTiet2"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqLietKeKhoiLuongGiangDayChiTiet2ExpressionBuilder : SqlExpressionBuilder<ViewKcqLietKeKhoiLuongGiangDayChiTiet2Column>
	{
	}
	
	#endregion ViewKcqLietKeKhoiLuongGiangDayChiTiet2ExpressionBuilder		
}

