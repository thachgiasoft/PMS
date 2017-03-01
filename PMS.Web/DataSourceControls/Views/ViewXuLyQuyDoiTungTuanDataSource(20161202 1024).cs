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
	/// Represents the DataRepository.ViewXuLyQuyDoiTungTuanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewXuLyQuyDoiTungTuanDataSourceDesigner))]
	public class ViewXuLyQuyDoiTungTuanDataSource : ReadOnlyDataSource<ViewXuLyQuyDoiTungTuan>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewXuLyQuyDoiTungTuanDataSource class.
		/// </summary>
		public ViewXuLyQuyDoiTungTuanDataSource() : base(new ViewXuLyQuyDoiTungTuanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewXuLyQuyDoiTungTuanDataSourceView used by the ViewXuLyQuyDoiTungTuanDataSource.
		/// </summary>
		protected ViewXuLyQuyDoiTungTuanDataSourceView ViewXuLyQuyDoiTungTuanView
		{
			get { return ( View as ViewXuLyQuyDoiTungTuanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewXuLyQuyDoiTungTuanDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewXuLyQuyDoiTungTuanSelectMethod SelectMethod
		{
			get
			{
				ViewXuLyQuyDoiTungTuanSelectMethod selectMethod = ViewXuLyQuyDoiTungTuanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewXuLyQuyDoiTungTuanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewXuLyQuyDoiTungTuanDataSourceView class that is to be
		/// used by the ViewXuLyQuyDoiTungTuanDataSource.
		/// </summary>
		/// <returns>An instance of the ViewXuLyQuyDoiTungTuanDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewXuLyQuyDoiTungTuan, Object> GetNewDataSourceView()
		{
			return new ViewXuLyQuyDoiTungTuanDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewXuLyQuyDoiTungTuanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewXuLyQuyDoiTungTuanDataSourceView : ReadOnlyDataSourceView<ViewXuLyQuyDoiTungTuan>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewXuLyQuyDoiTungTuanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewXuLyQuyDoiTungTuanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewXuLyQuyDoiTungTuanDataSourceView(ViewXuLyQuyDoiTungTuanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewXuLyQuyDoiTungTuanDataSource ViewXuLyQuyDoiTungTuanOwner
		{
			get { return Owner as ViewXuLyQuyDoiTungTuanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewXuLyQuyDoiTungTuanSelectMethod SelectMethod
		{
			get { return ViewXuLyQuyDoiTungTuanOwner.SelectMethod; }
			set { ViewXuLyQuyDoiTungTuanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewXuLyQuyDoiTungTuanService ViewXuLyQuyDoiTungTuanProvider
		{
			get { return Provider as ViewXuLyQuyDoiTungTuanService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewXuLyQuyDoiTungTuan> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewXuLyQuyDoiTungTuan> results = null;
			// ViewXuLyQuyDoiTungTuan item;
			count = 0;
			
			System.DateTime sp3237_TuNgay;
			System.DateTime sp3237_DenNgay;

			switch ( SelectMethod )
			{
				case ViewXuLyQuyDoiTungTuanSelectMethod.Get:
					results = ViewXuLyQuyDoiTungTuanProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewXuLyQuyDoiTungTuanSelectMethod.GetPaged:
					results = ViewXuLyQuyDoiTungTuanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewXuLyQuyDoiTungTuanSelectMethod.GetAll:
					results = ViewXuLyQuyDoiTungTuanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewXuLyQuyDoiTungTuanSelectMethod.Find:
					results = ViewXuLyQuyDoiTungTuanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewXuLyQuyDoiTungTuanSelectMethod.GetByTuNgayDenNgay:
					sp3237_TuNgay = (System.DateTime) EntityUtil.ChangeType(values["TuNgay"], typeof(System.DateTime));
					sp3237_DenNgay = (System.DateTime) EntityUtil.ChangeType(values["DenNgay"], typeof(System.DateTime));
					results = ViewXuLyQuyDoiTungTuanProvider.GetByTuNgayDenNgay(sp3237_TuNgay, sp3237_DenNgay, StartIndex, PageSize);
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

	#region ViewXuLyQuyDoiTungTuanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewXuLyQuyDoiTungTuanDataSource.SelectMethod property.
	/// </summary>
	public enum ViewXuLyQuyDoiTungTuanSelectMethod
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
	
	#endregion ViewXuLyQuyDoiTungTuanSelectMethod
	
	#region ViewXuLyQuyDoiTungTuanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewXuLyQuyDoiTungTuanDataSource class.
	/// </summary>
	public class ViewXuLyQuyDoiTungTuanDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewXuLyQuyDoiTungTuan>
	{
		/// <summary>
		/// Initializes a new instance of the ViewXuLyQuyDoiTungTuanDataSourceDesigner class.
		/// </summary>
		public ViewXuLyQuyDoiTungTuanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewXuLyQuyDoiTungTuanSelectMethod SelectMethod
		{
			get { return ((ViewXuLyQuyDoiTungTuanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewXuLyQuyDoiTungTuanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewXuLyQuyDoiTungTuanDataSourceActionList

	/// <summary>
	/// Supports the ViewXuLyQuyDoiTungTuanDataSourceDesigner class.
	/// </summary>
	internal class ViewXuLyQuyDoiTungTuanDataSourceActionList : DesignerActionList
	{
		private ViewXuLyQuyDoiTungTuanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewXuLyQuyDoiTungTuanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewXuLyQuyDoiTungTuanDataSourceActionList(ViewXuLyQuyDoiTungTuanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewXuLyQuyDoiTungTuanSelectMethod SelectMethod
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

	#endregion ViewXuLyQuyDoiTungTuanDataSourceActionList

	#endregion ViewXuLyQuyDoiTungTuanDataSourceDesigner

	#region ViewXuLyQuyDoiTungTuanFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewXuLyQuyDoiTungTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewXuLyQuyDoiTungTuanFilter : SqlFilter<ViewXuLyQuyDoiTungTuanColumn>
	{
	}

	#endregion ViewXuLyQuyDoiTungTuanFilter

	#region ViewXuLyQuyDoiTungTuanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewXuLyQuyDoiTungTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewXuLyQuyDoiTungTuanExpressionBuilder : SqlExpressionBuilder<ViewXuLyQuyDoiTungTuanColumn>
	{
	}
	
	#endregion ViewXuLyQuyDoiTungTuanExpressionBuilder		
}

