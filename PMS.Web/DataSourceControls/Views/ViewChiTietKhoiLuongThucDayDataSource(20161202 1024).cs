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
	/// Represents the DataRepository.ViewChiTietKhoiLuongThucDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewChiTietKhoiLuongThucDayDataSourceDesigner))]
	public class ViewChiTietKhoiLuongThucDayDataSource : ReadOnlyDataSource<ViewChiTietKhoiLuongThucDay>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongThucDayDataSource class.
		/// </summary>
		public ViewChiTietKhoiLuongThucDayDataSource() : base(new ViewChiTietKhoiLuongThucDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewChiTietKhoiLuongThucDayDataSourceView used by the ViewChiTietKhoiLuongThucDayDataSource.
		/// </summary>
		protected ViewChiTietKhoiLuongThucDayDataSourceView ViewChiTietKhoiLuongThucDayView
		{
			get { return ( View as ViewChiTietKhoiLuongThucDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewChiTietKhoiLuongThucDayDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewChiTietKhoiLuongThucDaySelectMethod SelectMethod
		{
			get
			{
				ViewChiTietKhoiLuongThucDaySelectMethod selectMethod = ViewChiTietKhoiLuongThucDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewChiTietKhoiLuongThucDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewChiTietKhoiLuongThucDayDataSourceView class that is to be
		/// used by the ViewChiTietKhoiLuongThucDayDataSource.
		/// </summary>
		/// <returns>An instance of the ViewChiTietKhoiLuongThucDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewChiTietKhoiLuongThucDay, Object> GetNewDataSourceView()
		{
			return new ViewChiTietKhoiLuongThucDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewChiTietKhoiLuongThucDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewChiTietKhoiLuongThucDayDataSourceView : ReadOnlyDataSourceView<ViewChiTietKhoiLuongThucDay>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongThucDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewChiTietKhoiLuongThucDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewChiTietKhoiLuongThucDayDataSourceView(ViewChiTietKhoiLuongThucDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewChiTietKhoiLuongThucDayDataSource ViewChiTietKhoiLuongThucDayOwner
		{
			get { return Owner as ViewChiTietKhoiLuongThucDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewChiTietKhoiLuongThucDaySelectMethod SelectMethod
		{
			get { return ViewChiTietKhoiLuongThucDayOwner.SelectMethod; }
			set { ViewChiTietKhoiLuongThucDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewChiTietKhoiLuongThucDayService ViewChiTietKhoiLuongThucDayProvider
		{
			get { return Provider as ViewChiTietKhoiLuongThucDayService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewChiTietKhoiLuongThucDay> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewChiTietKhoiLuongThucDay> results = null;
			// ViewChiTietKhoiLuongThucDay item;
			count = 0;
			
			System.String sp3037_NamHoc;
			System.String sp3037_HocKy;

			switch ( SelectMethod )
			{
				case ViewChiTietKhoiLuongThucDaySelectMethod.Get:
					results = ViewChiTietKhoiLuongThucDayProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewChiTietKhoiLuongThucDaySelectMethod.GetPaged:
					results = ViewChiTietKhoiLuongThucDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewChiTietKhoiLuongThucDaySelectMethod.GetAll:
					results = ViewChiTietKhoiLuongThucDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewChiTietKhoiLuongThucDaySelectMethod.Find:
					results = ViewChiTietKhoiLuongThucDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewChiTietKhoiLuongThucDaySelectMethod.GetByNamHocHocKy:
					sp3037_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3037_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewChiTietKhoiLuongThucDayProvider.GetByNamHocHocKy(sp3037_NamHoc, sp3037_HocKy, StartIndex, PageSize);
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

	#region ViewChiTietKhoiLuongThucDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewChiTietKhoiLuongThucDayDataSource.SelectMethod property.
	/// </summary>
	public enum ViewChiTietKhoiLuongThucDaySelectMethod
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
	
	#endregion ViewChiTietKhoiLuongThucDaySelectMethod
	
	#region ViewChiTietKhoiLuongThucDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewChiTietKhoiLuongThucDayDataSource class.
	/// </summary>
	public class ViewChiTietKhoiLuongThucDayDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewChiTietKhoiLuongThucDay>
	{
		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongThucDayDataSourceDesigner class.
		/// </summary>
		public ViewChiTietKhoiLuongThucDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewChiTietKhoiLuongThucDaySelectMethod SelectMethod
		{
			get { return ((ViewChiTietKhoiLuongThucDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewChiTietKhoiLuongThucDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewChiTietKhoiLuongThucDayDataSourceActionList

	/// <summary>
	/// Supports the ViewChiTietKhoiLuongThucDayDataSourceDesigner class.
	/// </summary>
	internal class ViewChiTietKhoiLuongThucDayDataSourceActionList : DesignerActionList
	{
		private ViewChiTietKhoiLuongThucDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongThucDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewChiTietKhoiLuongThucDayDataSourceActionList(ViewChiTietKhoiLuongThucDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewChiTietKhoiLuongThucDaySelectMethod SelectMethod
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

	#endregion ViewChiTietKhoiLuongThucDayDataSourceActionList

	#endregion ViewChiTietKhoiLuongThucDayDataSourceDesigner

	#region ViewChiTietKhoiLuongThucDayFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietKhoiLuongThucDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietKhoiLuongThucDayFilter : SqlFilter<ViewChiTietKhoiLuongThucDayColumn>
	{
	}

	#endregion ViewChiTietKhoiLuongThucDayFilter

	#region ViewChiTietKhoiLuongThucDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietKhoiLuongThucDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietKhoiLuongThucDayExpressionBuilder : SqlExpressionBuilder<ViewChiTietKhoiLuongThucDayColumn>
	{
	}
	
	#endregion ViewChiTietKhoiLuongThucDayExpressionBuilder		
}

