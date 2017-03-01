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
	/// Represents the DataRepository.ViewDoiTuongDonGiaProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewDoiTuongDonGiaDataSourceDesigner))]
	public class ViewDoiTuongDonGiaDataSource : ReadOnlyDataSource<ViewDoiTuongDonGia>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDoiTuongDonGiaDataSource class.
		/// </summary>
		public ViewDoiTuongDonGiaDataSource() : base(new ViewDoiTuongDonGiaService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewDoiTuongDonGiaDataSourceView used by the ViewDoiTuongDonGiaDataSource.
		/// </summary>
		protected ViewDoiTuongDonGiaDataSourceView ViewDoiTuongDonGiaView
		{
			get { return ( View as ViewDoiTuongDonGiaDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewDoiTuongDonGiaDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewDoiTuongDonGiaSelectMethod SelectMethod
		{
			get
			{
				ViewDoiTuongDonGiaSelectMethod selectMethod = ViewDoiTuongDonGiaSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewDoiTuongDonGiaSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewDoiTuongDonGiaDataSourceView class that is to be
		/// used by the ViewDoiTuongDonGiaDataSource.
		/// </summary>
		/// <returns>An instance of the ViewDoiTuongDonGiaDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewDoiTuongDonGia, Object> GetNewDataSourceView()
		{
			return new ViewDoiTuongDonGiaDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewDoiTuongDonGiaDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewDoiTuongDonGiaDataSourceView : ReadOnlyDataSourceView<ViewDoiTuongDonGia>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDoiTuongDonGiaDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewDoiTuongDonGiaDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewDoiTuongDonGiaDataSourceView(ViewDoiTuongDonGiaDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewDoiTuongDonGiaDataSource ViewDoiTuongDonGiaOwner
		{
			get { return Owner as ViewDoiTuongDonGiaDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewDoiTuongDonGiaSelectMethod SelectMethod
		{
			get { return ViewDoiTuongDonGiaOwner.SelectMethod; }
			set { ViewDoiTuongDonGiaOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewDoiTuongDonGiaService ViewDoiTuongDonGiaProvider
		{
			get { return Provider as ViewDoiTuongDonGiaService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewDoiTuongDonGia> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewDoiTuongDonGia> results = null;
			// ViewDoiTuongDonGia item;
			count = 0;
			
			System.String sp3047_MaQuanLy;

			switch ( SelectMethod )
			{
				case ViewDoiTuongDonGiaSelectMethod.Get:
					results = ViewDoiTuongDonGiaProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewDoiTuongDonGiaSelectMethod.GetPaged:
					results = ViewDoiTuongDonGiaProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewDoiTuongDonGiaSelectMethod.GetAll:
					results = ViewDoiTuongDonGiaProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewDoiTuongDonGiaSelectMethod.Find:
					results = ViewDoiTuongDonGiaProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewDoiTuongDonGiaSelectMethod.GetTenGoiByMaQuanLy:
					sp3047_MaQuanLy = (System.String) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.String));
					results = ViewDoiTuongDonGiaProvider.GetTenGoiByMaQuanLy(sp3047_MaQuanLy, StartIndex, PageSize);
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

	#region ViewDoiTuongDonGiaSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewDoiTuongDonGiaDataSource.SelectMethod property.
	/// </summary>
	public enum ViewDoiTuongDonGiaSelectMethod
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
		/// Represents the GetTenGoiByMaQuanLy method.
		/// </summary>
		GetTenGoiByMaQuanLy
	}
	
	#endregion ViewDoiTuongDonGiaSelectMethod
	
	#region ViewDoiTuongDonGiaDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewDoiTuongDonGiaDataSource class.
	/// </summary>
	public class ViewDoiTuongDonGiaDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewDoiTuongDonGia>
	{
		/// <summary>
		/// Initializes a new instance of the ViewDoiTuongDonGiaDataSourceDesigner class.
		/// </summary>
		public ViewDoiTuongDonGiaDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewDoiTuongDonGiaSelectMethod SelectMethod
		{
			get { return ((ViewDoiTuongDonGiaDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewDoiTuongDonGiaDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewDoiTuongDonGiaDataSourceActionList

	/// <summary>
	/// Supports the ViewDoiTuongDonGiaDataSourceDesigner class.
	/// </summary>
	internal class ViewDoiTuongDonGiaDataSourceActionList : DesignerActionList
	{
		private ViewDoiTuongDonGiaDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewDoiTuongDonGiaDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewDoiTuongDonGiaDataSourceActionList(ViewDoiTuongDonGiaDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewDoiTuongDonGiaSelectMethod SelectMethod
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

	#endregion ViewDoiTuongDonGiaDataSourceActionList

	#endregion ViewDoiTuongDonGiaDataSourceDesigner

	#region ViewDoiTuongDonGiaFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDoiTuongDonGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDoiTuongDonGiaFilter : SqlFilter<ViewDoiTuongDonGiaColumn>
	{
	}

	#endregion ViewDoiTuongDonGiaFilter

	#region ViewDoiTuongDonGiaExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDoiTuongDonGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDoiTuongDonGiaExpressionBuilder : SqlExpressionBuilder<ViewDoiTuongDonGiaColumn>
	{
	}
	
	#endregion ViewDoiTuongDonGiaExpressionBuilder		
}

