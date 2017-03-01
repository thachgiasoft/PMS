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
	/// Represents the DataRepository.ViewUteKhoiLuongQuyDoi2Provider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewUteKhoiLuongQuyDoi2DataSourceDesigner))]
	public class ViewUteKhoiLuongQuyDoi2DataSource : ReadOnlyDataSource<ViewUteKhoiLuongQuyDoi2>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongQuyDoi2DataSource class.
		/// </summary>
		public ViewUteKhoiLuongQuyDoi2DataSource() : base(new ViewUteKhoiLuongQuyDoi2Service())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewUteKhoiLuongQuyDoi2DataSourceView used by the ViewUteKhoiLuongQuyDoi2DataSource.
		/// </summary>
		protected ViewUteKhoiLuongQuyDoi2DataSourceView ViewUteKhoiLuongQuyDoi2View
		{
			get { return ( View as ViewUteKhoiLuongQuyDoi2DataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewUteKhoiLuongQuyDoi2DataSource control invokes to retrieve data.
		/// </summary>
		public new ViewUteKhoiLuongQuyDoi2SelectMethod SelectMethod
		{
			get
			{
				ViewUteKhoiLuongQuyDoi2SelectMethod selectMethod = ViewUteKhoiLuongQuyDoi2SelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewUteKhoiLuongQuyDoi2SelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewUteKhoiLuongQuyDoi2DataSourceView class that is to be
		/// used by the ViewUteKhoiLuongQuyDoi2DataSource.
		/// </summary>
		/// <returns>An instance of the ViewUteKhoiLuongQuyDoi2DataSourceView class.</returns>
		protected override BaseDataSourceView<ViewUteKhoiLuongQuyDoi2, Object> GetNewDataSourceView()
		{
			return new ViewUteKhoiLuongQuyDoi2DataSourceView(this, DefaultViewName);
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
	/// Supports the ViewUteKhoiLuongQuyDoi2DataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewUteKhoiLuongQuyDoi2DataSourceView : ReadOnlyDataSourceView<ViewUteKhoiLuongQuyDoi2>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongQuyDoi2DataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewUteKhoiLuongQuyDoi2DataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewUteKhoiLuongQuyDoi2DataSourceView(ViewUteKhoiLuongQuyDoi2DataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewUteKhoiLuongQuyDoi2DataSource ViewUteKhoiLuongQuyDoi2Owner
		{
			get { return Owner as ViewUteKhoiLuongQuyDoi2DataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewUteKhoiLuongQuyDoi2SelectMethod SelectMethod
		{
			get { return ViewUteKhoiLuongQuyDoi2Owner.SelectMethod; }
			set { ViewUteKhoiLuongQuyDoi2Owner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewUteKhoiLuongQuyDoi2Service ViewUteKhoiLuongQuyDoi2Provider
		{
			get { return Provider as ViewUteKhoiLuongQuyDoi2Service; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewUteKhoiLuongQuyDoi2> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewUteKhoiLuongQuyDoi2> results = null;
			// ViewUteKhoiLuongQuyDoi2 item;
			count = 0;
			
			System.String sp3234_NamHoc;
			System.String sp3234_HocKy;

			switch ( SelectMethod )
			{
				case ViewUteKhoiLuongQuyDoi2SelectMethod.Get:
					results = ViewUteKhoiLuongQuyDoi2Provider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewUteKhoiLuongQuyDoi2SelectMethod.GetPaged:
					results = ViewUteKhoiLuongQuyDoi2Provider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewUteKhoiLuongQuyDoi2SelectMethod.GetAll:
					results = ViewUteKhoiLuongQuyDoi2Provider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewUteKhoiLuongQuyDoi2SelectMethod.Find:
					results = ViewUteKhoiLuongQuyDoi2Provider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewUteKhoiLuongQuyDoi2SelectMethod.GetByNamHocHocKy:
					sp3234_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3234_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewUteKhoiLuongQuyDoi2Provider.GetByNamHocHocKy(sp3234_NamHoc, sp3234_HocKy, StartIndex, PageSize);
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

	#region ViewUteKhoiLuongQuyDoi2SelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewUteKhoiLuongQuyDoi2DataSource.SelectMethod property.
	/// </summary>
	public enum ViewUteKhoiLuongQuyDoi2SelectMethod
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
	
	#endregion ViewUteKhoiLuongQuyDoi2SelectMethod
	
	#region ViewUteKhoiLuongQuyDoi2DataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewUteKhoiLuongQuyDoi2DataSource class.
	/// </summary>
	public class ViewUteKhoiLuongQuyDoi2DataSourceDesigner : ReadOnlyDataSourceDesigner<ViewUteKhoiLuongQuyDoi2>
	{
		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongQuyDoi2DataSourceDesigner class.
		/// </summary>
		public ViewUteKhoiLuongQuyDoi2DataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewUteKhoiLuongQuyDoi2SelectMethod SelectMethod
		{
			get { return ((ViewUteKhoiLuongQuyDoi2DataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewUteKhoiLuongQuyDoi2DataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewUteKhoiLuongQuyDoi2DataSourceActionList

	/// <summary>
	/// Supports the ViewUteKhoiLuongQuyDoi2DataSourceDesigner class.
	/// </summary>
	internal class ViewUteKhoiLuongQuyDoi2DataSourceActionList : DesignerActionList
	{
		private ViewUteKhoiLuongQuyDoi2DataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongQuyDoi2DataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewUteKhoiLuongQuyDoi2DataSourceActionList(ViewUteKhoiLuongQuyDoi2DataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewUteKhoiLuongQuyDoi2SelectMethod SelectMethod
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

	#endregion ViewUteKhoiLuongQuyDoi2DataSourceActionList

	#endregion ViewUteKhoiLuongQuyDoi2DataSourceDesigner

	#region ViewUteKhoiLuongQuyDoi2Filter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewUteKhoiLuongQuyDoi2"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewUteKhoiLuongQuyDoi2Filter : SqlFilter<ViewUteKhoiLuongQuyDoi2Column>
	{
	}

	#endregion ViewUteKhoiLuongQuyDoi2Filter

	#region ViewUteKhoiLuongQuyDoi2ExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewUteKhoiLuongQuyDoi2"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewUteKhoiLuongQuyDoi2ExpressionBuilder : SqlExpressionBuilder<ViewUteKhoiLuongQuyDoi2Column>
	{
	}
	
	#endregion ViewUteKhoiLuongQuyDoi2ExpressionBuilder		
}

