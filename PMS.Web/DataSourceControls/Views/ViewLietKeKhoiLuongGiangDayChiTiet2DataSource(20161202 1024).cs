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
	/// Represents the DataRepository.ViewLietKeKhoiLuongGiangDayChiTiet2Provider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceDesigner))]
	public class ViewLietKeKhoiLuongGiangDayChiTiet2DataSource : ReadOnlyDataSource<ViewLietKeKhoiLuongGiangDayChiTiet2>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTiet2DataSource class.
		/// </summary>
		public ViewLietKeKhoiLuongGiangDayChiTiet2DataSource() : base(new ViewLietKeKhoiLuongGiangDayChiTiet2Service())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceView used by the ViewLietKeKhoiLuongGiangDayChiTiet2DataSource.
		/// </summary>
		protected ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceView ViewLietKeKhoiLuongGiangDayChiTiet2View
		{
			get { return ( View as ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewLietKeKhoiLuongGiangDayChiTiet2DataSource control invokes to retrieve data.
		/// </summary>
		public new ViewLietKeKhoiLuongGiangDayChiTiet2SelectMethod SelectMethod
		{
			get
			{
				ViewLietKeKhoiLuongGiangDayChiTiet2SelectMethod selectMethod = ViewLietKeKhoiLuongGiangDayChiTiet2SelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewLietKeKhoiLuongGiangDayChiTiet2SelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceView class that is to be
		/// used by the ViewLietKeKhoiLuongGiangDayChiTiet2DataSource.
		/// </summary>
		/// <returns>An instance of the ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceView class.</returns>
		protected override BaseDataSourceView<ViewLietKeKhoiLuongGiangDayChiTiet2, Object> GetNewDataSourceView()
		{
			return new ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceView(this, DefaultViewName);
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
	/// Supports the ViewLietKeKhoiLuongGiangDayChiTiet2DataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceView : ReadOnlyDataSourceView<ViewLietKeKhoiLuongGiangDayChiTiet2>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewLietKeKhoiLuongGiangDayChiTiet2DataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceView(ViewLietKeKhoiLuongGiangDayChiTiet2DataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewLietKeKhoiLuongGiangDayChiTiet2DataSource ViewLietKeKhoiLuongGiangDayChiTiet2Owner
		{
			get { return Owner as ViewLietKeKhoiLuongGiangDayChiTiet2DataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewLietKeKhoiLuongGiangDayChiTiet2SelectMethod SelectMethod
		{
			get { return ViewLietKeKhoiLuongGiangDayChiTiet2Owner.SelectMethod; }
			set { ViewLietKeKhoiLuongGiangDayChiTiet2Owner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewLietKeKhoiLuongGiangDayChiTiet2Service ViewLietKeKhoiLuongGiangDayChiTiet2Provider
		{
			get { return Provider as ViewLietKeKhoiLuongGiangDayChiTiet2Service; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewLietKeKhoiLuongGiangDayChiTiet2> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewLietKeKhoiLuongGiangDayChiTiet2> results = null;
			// ViewLietKeKhoiLuongGiangDayChiTiet2 item;
			count = 0;
			
			System.String sp3132_NamHoc;
			System.String sp3132_HocKy;

			switch ( SelectMethod )
			{
				case ViewLietKeKhoiLuongGiangDayChiTiet2SelectMethod.Get:
					results = ViewLietKeKhoiLuongGiangDayChiTiet2Provider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewLietKeKhoiLuongGiangDayChiTiet2SelectMethod.GetPaged:
					results = ViewLietKeKhoiLuongGiangDayChiTiet2Provider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewLietKeKhoiLuongGiangDayChiTiet2SelectMethod.GetAll:
					results = ViewLietKeKhoiLuongGiangDayChiTiet2Provider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewLietKeKhoiLuongGiangDayChiTiet2SelectMethod.Find:
					results = ViewLietKeKhoiLuongGiangDayChiTiet2Provider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewLietKeKhoiLuongGiangDayChiTiet2SelectMethod.GetByNamHocHocKy:
					sp3132_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3132_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewLietKeKhoiLuongGiangDayChiTiet2Provider.GetByNamHocHocKy(sp3132_NamHoc, sp3132_HocKy, StartIndex, PageSize);
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

	#region ViewLietKeKhoiLuongGiangDayChiTiet2SelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewLietKeKhoiLuongGiangDayChiTiet2DataSource.SelectMethod property.
	/// </summary>
	public enum ViewLietKeKhoiLuongGiangDayChiTiet2SelectMethod
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
	
	#endregion ViewLietKeKhoiLuongGiangDayChiTiet2SelectMethod
	
	#region ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewLietKeKhoiLuongGiangDayChiTiet2DataSource class.
	/// </summary>
	public class ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceDesigner : ReadOnlyDataSourceDesigner<ViewLietKeKhoiLuongGiangDayChiTiet2>
	{
		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceDesigner class.
		/// </summary>
		public ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewLietKeKhoiLuongGiangDayChiTiet2SelectMethod SelectMethod
		{
			get { return ((ViewLietKeKhoiLuongGiangDayChiTiet2DataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceActionList

	/// <summary>
	/// Supports the ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceDesigner class.
	/// </summary>
	internal class ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceActionList : DesignerActionList
	{
		private ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceActionList(ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewLietKeKhoiLuongGiangDayChiTiet2SelectMethod SelectMethod
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

	#endregion ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceActionList

	#endregion ViewLietKeKhoiLuongGiangDayChiTiet2DataSourceDesigner

	#region ViewLietKeKhoiLuongGiangDayChiTiet2Filter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLietKeKhoiLuongGiangDayChiTiet2"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLietKeKhoiLuongGiangDayChiTiet2Filter : SqlFilter<ViewLietKeKhoiLuongGiangDayChiTiet2Column>
	{
	}

	#endregion ViewLietKeKhoiLuongGiangDayChiTiet2Filter

	#region ViewLietKeKhoiLuongGiangDayChiTiet2ExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLietKeKhoiLuongGiangDayChiTiet2"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLietKeKhoiLuongGiangDayChiTiet2ExpressionBuilder : SqlExpressionBuilder<ViewLietKeKhoiLuongGiangDayChiTiet2Column>
	{
	}
	
	#endregion ViewLietKeKhoiLuongGiangDayChiTiet2ExpressionBuilder		
}

