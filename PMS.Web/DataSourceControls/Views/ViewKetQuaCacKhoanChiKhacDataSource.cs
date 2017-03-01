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
	/// Represents the DataRepository.ViewKetQuaCacKhoanChiKhacProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKetQuaCacKhoanChiKhacDataSourceDesigner))]
	public class ViewKetQuaCacKhoanChiKhacDataSource : ReadOnlyDataSource<ViewKetQuaCacKhoanChiKhac>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaCacKhoanChiKhacDataSource class.
		/// </summary>
		public ViewKetQuaCacKhoanChiKhacDataSource() : base(new ViewKetQuaCacKhoanChiKhacService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKetQuaCacKhoanChiKhacDataSourceView used by the ViewKetQuaCacKhoanChiKhacDataSource.
		/// </summary>
		protected ViewKetQuaCacKhoanChiKhacDataSourceView ViewKetQuaCacKhoanChiKhacView
		{
			get { return ( View as ViewKetQuaCacKhoanChiKhacDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewKetQuaCacKhoanChiKhacDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewKetQuaCacKhoanChiKhacSelectMethod SelectMethod
		{
			get
			{
				ViewKetQuaCacKhoanChiKhacSelectMethod selectMethod = ViewKetQuaCacKhoanChiKhacSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewKetQuaCacKhoanChiKhacSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKetQuaCacKhoanChiKhacDataSourceView class that is to be
		/// used by the ViewKetQuaCacKhoanChiKhacDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKetQuaCacKhoanChiKhacDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKetQuaCacKhoanChiKhac, Object> GetNewDataSourceView()
		{
			return new ViewKetQuaCacKhoanChiKhacDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKetQuaCacKhoanChiKhacDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKetQuaCacKhoanChiKhacDataSourceView : ReadOnlyDataSourceView<ViewKetQuaCacKhoanChiKhac>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaCacKhoanChiKhacDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKetQuaCacKhoanChiKhacDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKetQuaCacKhoanChiKhacDataSourceView(ViewKetQuaCacKhoanChiKhacDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKetQuaCacKhoanChiKhacDataSource ViewKetQuaCacKhoanChiKhacOwner
		{
			get { return Owner as ViewKetQuaCacKhoanChiKhacDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewKetQuaCacKhoanChiKhacSelectMethod SelectMethod
		{
			get { return ViewKetQuaCacKhoanChiKhacOwner.SelectMethod; }
			set { ViewKetQuaCacKhoanChiKhacOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKetQuaCacKhoanChiKhacService ViewKetQuaCacKhoanChiKhacProvider
		{
			get { return Provider as ViewKetQuaCacKhoanChiKhacService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewKetQuaCacKhoanChiKhac> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewKetQuaCacKhoanChiKhac> results = null;
			// ViewKetQuaCacKhoanChiKhac item;
			count = 0;
			
			System.DateTime sp998_TuNgay;
			System.DateTime sp998_DenNgay;

			switch ( SelectMethod )
			{
				case ViewKetQuaCacKhoanChiKhacSelectMethod.Get:
					results = ViewKetQuaCacKhoanChiKhacProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewKetQuaCacKhoanChiKhacSelectMethod.GetPaged:
					results = ViewKetQuaCacKhoanChiKhacProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewKetQuaCacKhoanChiKhacSelectMethod.GetAll:
					results = ViewKetQuaCacKhoanChiKhacProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewKetQuaCacKhoanChiKhacSelectMethod.Find:
					results = ViewKetQuaCacKhoanChiKhacProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewKetQuaCacKhoanChiKhacSelectMethod.GetByNgay:
					sp998_TuNgay = (System.DateTime) EntityUtil.ChangeType(values["TuNgay"], typeof(System.DateTime));
					sp998_DenNgay = (System.DateTime) EntityUtil.ChangeType(values["DenNgay"], typeof(System.DateTime));
					results = ViewKetQuaCacKhoanChiKhacProvider.GetByNgay(sp998_TuNgay, sp998_DenNgay, StartIndex, PageSize);
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

	#region ViewKetQuaCacKhoanChiKhacSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewKetQuaCacKhoanChiKhacDataSource.SelectMethod property.
	/// </summary>
	public enum ViewKetQuaCacKhoanChiKhacSelectMethod
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
		/// Represents the GetByNgay method.
		/// </summary>
		GetByNgay
	}
	
	#endregion ViewKetQuaCacKhoanChiKhacSelectMethod
	
	#region ViewKetQuaCacKhoanChiKhacDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKetQuaCacKhoanChiKhacDataSource class.
	/// </summary>
	public class ViewKetQuaCacKhoanChiKhacDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKetQuaCacKhoanChiKhac>
	{
		/// <summary>
		/// Initializes a new instance of the ViewKetQuaCacKhoanChiKhacDataSourceDesigner class.
		/// </summary>
		public ViewKetQuaCacKhoanChiKhacDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewKetQuaCacKhoanChiKhacSelectMethod SelectMethod
		{
			get { return ((ViewKetQuaCacKhoanChiKhacDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewKetQuaCacKhoanChiKhacDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewKetQuaCacKhoanChiKhacDataSourceActionList

	/// <summary>
	/// Supports the ViewKetQuaCacKhoanChiKhacDataSourceDesigner class.
	/// </summary>
	internal class ViewKetQuaCacKhoanChiKhacDataSourceActionList : DesignerActionList
	{
		private ViewKetQuaCacKhoanChiKhacDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaCacKhoanChiKhacDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewKetQuaCacKhoanChiKhacDataSourceActionList(ViewKetQuaCacKhoanChiKhacDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewKetQuaCacKhoanChiKhacSelectMethod SelectMethod
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

	#endregion ViewKetQuaCacKhoanChiKhacDataSourceActionList

	#endregion ViewKetQuaCacKhoanChiKhacDataSourceDesigner

	#region ViewKetQuaCacKhoanChiKhacFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKetQuaCacKhoanChiKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKetQuaCacKhoanChiKhacFilter : SqlFilter<ViewKetQuaCacKhoanChiKhacColumn>
	{
	}

	#endregion ViewKetQuaCacKhoanChiKhacFilter

	#region ViewKetQuaCacKhoanChiKhacExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKetQuaCacKhoanChiKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKetQuaCacKhoanChiKhacExpressionBuilder : SqlExpressionBuilder<ViewKetQuaCacKhoanChiKhacColumn>
	{
	}
	
	#endregion ViewKetQuaCacKhoanChiKhacExpressionBuilder		
}

