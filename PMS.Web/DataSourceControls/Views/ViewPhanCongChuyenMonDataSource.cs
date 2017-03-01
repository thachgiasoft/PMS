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
	/// Represents the DataRepository.ViewPhanCongChuyenMonProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewPhanCongChuyenMonDataSourceDesigner))]
	public class ViewPhanCongChuyenMonDataSource : ReadOnlyDataSource<ViewPhanCongChuyenMon>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongChuyenMonDataSource class.
		/// </summary>
		public ViewPhanCongChuyenMonDataSource() : base(new ViewPhanCongChuyenMonService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewPhanCongChuyenMonDataSourceView used by the ViewPhanCongChuyenMonDataSource.
		/// </summary>
		protected ViewPhanCongChuyenMonDataSourceView ViewPhanCongChuyenMonView
		{
			get { return ( View as ViewPhanCongChuyenMonDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewPhanCongChuyenMonDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewPhanCongChuyenMonSelectMethod SelectMethod
		{
			get
			{
				ViewPhanCongChuyenMonSelectMethod selectMethod = ViewPhanCongChuyenMonSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewPhanCongChuyenMonSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewPhanCongChuyenMonDataSourceView class that is to be
		/// used by the ViewPhanCongChuyenMonDataSource.
		/// </summary>
		/// <returns>An instance of the ViewPhanCongChuyenMonDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewPhanCongChuyenMon, Object> GetNewDataSourceView()
		{
			return new ViewPhanCongChuyenMonDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewPhanCongChuyenMonDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewPhanCongChuyenMonDataSourceView : ReadOnlyDataSourceView<ViewPhanCongChuyenMon>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongChuyenMonDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewPhanCongChuyenMonDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewPhanCongChuyenMonDataSourceView(ViewPhanCongChuyenMonDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewPhanCongChuyenMonDataSource ViewPhanCongChuyenMonOwner
		{
			get { return Owner as ViewPhanCongChuyenMonDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewPhanCongChuyenMonSelectMethod SelectMethod
		{
			get { return ViewPhanCongChuyenMonOwner.SelectMethod; }
			set { ViewPhanCongChuyenMonOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewPhanCongChuyenMonService ViewPhanCongChuyenMonProvider
		{
			get { return Provider as ViewPhanCongChuyenMonService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewPhanCongChuyenMon> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewPhanCongChuyenMon> results = null;
			// ViewPhanCongChuyenMon item;
			count = 0;
			
			System.String sp1065_MaDonVi;

			switch ( SelectMethod )
			{
				case ViewPhanCongChuyenMonSelectMethod.Get:
					results = ViewPhanCongChuyenMonProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewPhanCongChuyenMonSelectMethod.GetPaged:
					results = ViewPhanCongChuyenMonProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewPhanCongChuyenMonSelectMethod.GetAll:
					results = ViewPhanCongChuyenMonProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewPhanCongChuyenMonSelectMethod.Find:
					results = ViewPhanCongChuyenMonProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewPhanCongChuyenMonSelectMethod.GetByMaDonVi:
					sp1065_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = ViewPhanCongChuyenMonProvider.GetByMaDonVi(sp1065_MaDonVi, StartIndex, PageSize);
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

	#region ViewPhanCongChuyenMonSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewPhanCongChuyenMonDataSource.SelectMethod property.
	/// </summary>
	public enum ViewPhanCongChuyenMonSelectMethod
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
		/// Represents the GetByMaDonVi method.
		/// </summary>
		GetByMaDonVi
	}
	
	#endregion ViewPhanCongChuyenMonSelectMethod
	
	#region ViewPhanCongChuyenMonDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewPhanCongChuyenMonDataSource class.
	/// </summary>
	public class ViewPhanCongChuyenMonDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewPhanCongChuyenMon>
	{
		/// <summary>
		/// Initializes a new instance of the ViewPhanCongChuyenMonDataSourceDesigner class.
		/// </summary>
		public ViewPhanCongChuyenMonDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewPhanCongChuyenMonSelectMethod SelectMethod
		{
			get { return ((ViewPhanCongChuyenMonDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewPhanCongChuyenMonDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewPhanCongChuyenMonDataSourceActionList

	/// <summary>
	/// Supports the ViewPhanCongChuyenMonDataSourceDesigner class.
	/// </summary>
	internal class ViewPhanCongChuyenMonDataSourceActionList : DesignerActionList
	{
		private ViewPhanCongChuyenMonDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongChuyenMonDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewPhanCongChuyenMonDataSourceActionList(ViewPhanCongChuyenMonDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewPhanCongChuyenMonSelectMethod SelectMethod
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

	#endregion ViewPhanCongChuyenMonDataSourceActionList

	#endregion ViewPhanCongChuyenMonDataSourceDesigner

	#region ViewPhanCongChuyenMonFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanCongChuyenMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanCongChuyenMonFilter : SqlFilter<ViewPhanCongChuyenMonColumn>
	{
	}

	#endregion ViewPhanCongChuyenMonFilter

	#region ViewPhanCongChuyenMonExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanCongChuyenMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanCongChuyenMonExpressionBuilder : SqlExpressionBuilder<ViewPhanCongChuyenMonColumn>
	{
	}
	
	#endregion ViewPhanCongChuyenMonExpressionBuilder		
}

