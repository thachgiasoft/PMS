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
	/// Represents the DataRepository.ViewKcqUteKhoiLuongQuyDoi2Provider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKcqUteKhoiLuongQuyDoi2DataSourceDesigner))]
	public class ViewKcqUteKhoiLuongQuyDoi2DataSource : ReadOnlyDataSource<ViewKcqUteKhoiLuongQuyDoi2>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqUteKhoiLuongQuyDoi2DataSource class.
		/// </summary>
		public ViewKcqUteKhoiLuongQuyDoi2DataSource() : base(new ViewKcqUteKhoiLuongQuyDoi2Service())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKcqUteKhoiLuongQuyDoi2DataSourceView used by the ViewKcqUteKhoiLuongQuyDoi2DataSource.
		/// </summary>
		protected ViewKcqUteKhoiLuongQuyDoi2DataSourceView ViewKcqUteKhoiLuongQuyDoi2View
		{
			get { return ( View as ViewKcqUteKhoiLuongQuyDoi2DataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewKcqUteKhoiLuongQuyDoi2DataSource control invokes to retrieve data.
		/// </summary>
		public new ViewKcqUteKhoiLuongQuyDoi2SelectMethod SelectMethod
		{
			get
			{
				ViewKcqUteKhoiLuongQuyDoi2SelectMethod selectMethod = ViewKcqUteKhoiLuongQuyDoi2SelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewKcqUteKhoiLuongQuyDoi2SelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKcqUteKhoiLuongQuyDoi2DataSourceView class that is to be
		/// used by the ViewKcqUteKhoiLuongQuyDoi2DataSource.
		/// </summary>
		/// <returns>An instance of the ViewKcqUteKhoiLuongQuyDoi2DataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKcqUteKhoiLuongQuyDoi2, Object> GetNewDataSourceView()
		{
			return new ViewKcqUteKhoiLuongQuyDoi2DataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKcqUteKhoiLuongQuyDoi2DataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKcqUteKhoiLuongQuyDoi2DataSourceView : ReadOnlyDataSourceView<ViewKcqUteKhoiLuongQuyDoi2>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqUteKhoiLuongQuyDoi2DataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKcqUteKhoiLuongQuyDoi2DataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKcqUteKhoiLuongQuyDoi2DataSourceView(ViewKcqUteKhoiLuongQuyDoi2DataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKcqUteKhoiLuongQuyDoi2DataSource ViewKcqUteKhoiLuongQuyDoi2Owner
		{
			get { return Owner as ViewKcqUteKhoiLuongQuyDoi2DataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewKcqUteKhoiLuongQuyDoi2SelectMethod SelectMethod
		{
			get { return ViewKcqUteKhoiLuongQuyDoi2Owner.SelectMethod; }
			set { ViewKcqUteKhoiLuongQuyDoi2Owner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKcqUteKhoiLuongQuyDoi2Service ViewKcqUteKhoiLuongQuyDoi2Provider
		{
			get { return Provider as ViewKcqUteKhoiLuongQuyDoi2Service; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewKcqUteKhoiLuongQuyDoi2> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewKcqUteKhoiLuongQuyDoi2> results = null;
			// ViewKcqUteKhoiLuongQuyDoi2 item;
			count = 0;
			
			System.String sp997_NamHoc;
			System.String sp997_HocKy;
			System.String sp997_Dot;
			System.String sp996_NamHoc;
			System.String sp996_HocKy;

			switch ( SelectMethod )
			{
				case ViewKcqUteKhoiLuongQuyDoi2SelectMethod.Get:
					results = ViewKcqUteKhoiLuongQuyDoi2Provider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewKcqUteKhoiLuongQuyDoi2SelectMethod.GetPaged:
					results = ViewKcqUteKhoiLuongQuyDoi2Provider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewKcqUteKhoiLuongQuyDoi2SelectMethod.GetAll:
					results = ViewKcqUteKhoiLuongQuyDoi2Provider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewKcqUteKhoiLuongQuyDoi2SelectMethod.Find:
					results = ViewKcqUteKhoiLuongQuyDoi2Provider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewKcqUteKhoiLuongQuyDoi2SelectMethod.GetByNamHocHocKyDot:
					sp997_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp997_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp997_Dot = (System.String) EntityUtil.ChangeType(values["Dot"], typeof(System.String));
					results = ViewKcqUteKhoiLuongQuyDoi2Provider.GetByNamHocHocKyDot(sp997_NamHoc, sp997_HocKy, sp997_Dot, StartIndex, PageSize);
					break;
				case ViewKcqUteKhoiLuongQuyDoi2SelectMethod.GetByNamHocHocKy:
					sp996_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp996_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewKcqUteKhoiLuongQuyDoi2Provider.GetByNamHocHocKy(sp996_NamHoc, sp996_HocKy, StartIndex, PageSize);
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

	#region ViewKcqUteKhoiLuongQuyDoi2SelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewKcqUteKhoiLuongQuyDoi2DataSource.SelectMethod property.
	/// </summary>
	public enum ViewKcqUteKhoiLuongQuyDoi2SelectMethod
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
	
	#endregion ViewKcqUteKhoiLuongQuyDoi2SelectMethod
	
	#region ViewKcqUteKhoiLuongQuyDoi2DataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKcqUteKhoiLuongQuyDoi2DataSource class.
	/// </summary>
	public class ViewKcqUteKhoiLuongQuyDoi2DataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKcqUteKhoiLuongQuyDoi2>
	{
		/// <summary>
		/// Initializes a new instance of the ViewKcqUteKhoiLuongQuyDoi2DataSourceDesigner class.
		/// </summary>
		public ViewKcqUteKhoiLuongQuyDoi2DataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewKcqUteKhoiLuongQuyDoi2SelectMethod SelectMethod
		{
			get { return ((ViewKcqUteKhoiLuongQuyDoi2DataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewKcqUteKhoiLuongQuyDoi2DataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewKcqUteKhoiLuongQuyDoi2DataSourceActionList

	/// <summary>
	/// Supports the ViewKcqUteKhoiLuongQuyDoi2DataSourceDesigner class.
	/// </summary>
	internal class ViewKcqUteKhoiLuongQuyDoi2DataSourceActionList : DesignerActionList
	{
		private ViewKcqUteKhoiLuongQuyDoi2DataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewKcqUteKhoiLuongQuyDoi2DataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewKcqUteKhoiLuongQuyDoi2DataSourceActionList(ViewKcqUteKhoiLuongQuyDoi2DataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewKcqUteKhoiLuongQuyDoi2SelectMethod SelectMethod
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

	#endregion ViewKcqUteKhoiLuongQuyDoi2DataSourceActionList

	#endregion ViewKcqUteKhoiLuongQuyDoi2DataSourceDesigner

	#region ViewKcqUteKhoiLuongQuyDoi2Filter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqUteKhoiLuongQuyDoi2"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqUteKhoiLuongQuyDoi2Filter : SqlFilter<ViewKcqUteKhoiLuongQuyDoi2Column>
	{
	}

	#endregion ViewKcqUteKhoiLuongQuyDoi2Filter

	#region ViewKcqUteKhoiLuongQuyDoi2ExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqUteKhoiLuongQuyDoi2"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqUteKhoiLuongQuyDoi2ExpressionBuilder : SqlExpressionBuilder<ViewKcqUteKhoiLuongQuyDoi2Column>
	{
	}
	
	#endregion ViewKcqUteKhoiLuongQuyDoi2ExpressionBuilder		
}

