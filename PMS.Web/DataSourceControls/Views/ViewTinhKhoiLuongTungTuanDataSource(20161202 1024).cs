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
	/// Represents the DataRepository.ViewTinhKhoiLuongTungTuanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewTinhKhoiLuongTungTuanDataSourceDesigner))]
	public class ViewTinhKhoiLuongTungTuanDataSource : ReadOnlyDataSource<ViewTinhKhoiLuongTungTuan>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongTungTuanDataSource class.
		/// </summary>
		public ViewTinhKhoiLuongTungTuanDataSource() : base(new ViewTinhKhoiLuongTungTuanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewTinhKhoiLuongTungTuanDataSourceView used by the ViewTinhKhoiLuongTungTuanDataSource.
		/// </summary>
		protected ViewTinhKhoiLuongTungTuanDataSourceView ViewTinhKhoiLuongTungTuanView
		{
			get { return ( View as ViewTinhKhoiLuongTungTuanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewTinhKhoiLuongTungTuanDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewTinhKhoiLuongTungTuanSelectMethod SelectMethod
		{
			get
			{
				ViewTinhKhoiLuongTungTuanSelectMethod selectMethod = ViewTinhKhoiLuongTungTuanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewTinhKhoiLuongTungTuanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewTinhKhoiLuongTungTuanDataSourceView class that is to be
		/// used by the ViewTinhKhoiLuongTungTuanDataSource.
		/// </summary>
		/// <returns>An instance of the ViewTinhKhoiLuongTungTuanDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewTinhKhoiLuongTungTuan, Object> GetNewDataSourceView()
		{
			return new ViewTinhKhoiLuongTungTuanDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewTinhKhoiLuongTungTuanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewTinhKhoiLuongTungTuanDataSourceView : ReadOnlyDataSourceView<ViewTinhKhoiLuongTungTuan>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongTungTuanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewTinhKhoiLuongTungTuanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewTinhKhoiLuongTungTuanDataSourceView(ViewTinhKhoiLuongTungTuanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewTinhKhoiLuongTungTuanDataSource ViewTinhKhoiLuongTungTuanOwner
		{
			get { return Owner as ViewTinhKhoiLuongTungTuanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewTinhKhoiLuongTungTuanSelectMethod SelectMethod
		{
			get { return ViewTinhKhoiLuongTungTuanOwner.SelectMethod; }
			set { ViewTinhKhoiLuongTungTuanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewTinhKhoiLuongTungTuanService ViewTinhKhoiLuongTungTuanProvider
		{
			get { return Provider as ViewTinhKhoiLuongTungTuanService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewTinhKhoiLuongTungTuan> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewTinhKhoiLuongTungTuan> results = null;
			// ViewTinhKhoiLuongTungTuan item;
			count = 0;
			
			System.DateTime sp3225_TuNgay;
			System.DateTime sp3225_DenNgay;

			switch ( SelectMethod )
			{
				case ViewTinhKhoiLuongTungTuanSelectMethod.Get:
					results = ViewTinhKhoiLuongTungTuanProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewTinhKhoiLuongTungTuanSelectMethod.GetPaged:
					results = ViewTinhKhoiLuongTungTuanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewTinhKhoiLuongTungTuanSelectMethod.GetAll:
					results = ViewTinhKhoiLuongTungTuanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewTinhKhoiLuongTungTuanSelectMethod.Find:
					results = ViewTinhKhoiLuongTungTuanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewTinhKhoiLuongTungTuanSelectMethod.GetByTuNgayDenNgay:
					sp3225_TuNgay = (System.DateTime) EntityUtil.ChangeType(values["TuNgay"], typeof(System.DateTime));
					sp3225_DenNgay = (System.DateTime) EntityUtil.ChangeType(values["DenNgay"], typeof(System.DateTime));
					results = ViewTinhKhoiLuongTungTuanProvider.GetByTuNgayDenNgay(sp3225_TuNgay, sp3225_DenNgay, StartIndex, PageSize);
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

	#region ViewTinhKhoiLuongTungTuanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewTinhKhoiLuongTungTuanDataSource.SelectMethod property.
	/// </summary>
	public enum ViewTinhKhoiLuongTungTuanSelectMethod
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
		/// Represents the GetByTuNgayDenNgay method.
		/// </summary>
		GetByTuNgayDenNgay
	}
	
	#endregion ViewTinhKhoiLuongTungTuanSelectMethod
	
	#region ViewTinhKhoiLuongTungTuanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewTinhKhoiLuongTungTuanDataSource class.
	/// </summary>
	public class ViewTinhKhoiLuongTungTuanDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewTinhKhoiLuongTungTuan>
	{
		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongTungTuanDataSourceDesigner class.
		/// </summary>
		public ViewTinhKhoiLuongTungTuanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewTinhKhoiLuongTungTuanSelectMethod SelectMethod
		{
			get { return ((ViewTinhKhoiLuongTungTuanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewTinhKhoiLuongTungTuanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewTinhKhoiLuongTungTuanDataSourceActionList

	/// <summary>
	/// Supports the ViewTinhKhoiLuongTungTuanDataSourceDesigner class.
	/// </summary>
	internal class ViewTinhKhoiLuongTungTuanDataSourceActionList : DesignerActionList
	{
		private ViewTinhKhoiLuongTungTuanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongTungTuanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewTinhKhoiLuongTungTuanDataSourceActionList(ViewTinhKhoiLuongTungTuanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewTinhKhoiLuongTungTuanSelectMethod SelectMethod
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

	#endregion ViewTinhKhoiLuongTungTuanDataSourceActionList

	#endregion ViewTinhKhoiLuongTungTuanDataSourceDesigner

	#region ViewTinhKhoiLuongTungTuanFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTinhKhoiLuongTungTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTinhKhoiLuongTungTuanFilter : SqlFilter<ViewTinhKhoiLuongTungTuanColumn>
	{
	}

	#endregion ViewTinhKhoiLuongTungTuanFilter

	#region ViewTinhKhoiLuongTungTuanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTinhKhoiLuongTungTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTinhKhoiLuongTungTuanExpressionBuilder : SqlExpressionBuilder<ViewTinhKhoiLuongTungTuanColumn>
	{
	}
	
	#endregion ViewTinhKhoiLuongTungTuanExpressionBuilder		
}

