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
	/// Represents the DataRepository.ViewKcqDonGiaNgoaiQuyCheProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKcqDonGiaNgoaiQuyCheDataSourceDesigner))]
	public class ViewKcqDonGiaNgoaiQuyCheDataSource : ReadOnlyDataSource<ViewKcqDonGiaNgoaiQuyChe>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqDonGiaNgoaiQuyCheDataSource class.
		/// </summary>
		public ViewKcqDonGiaNgoaiQuyCheDataSource() : base(new ViewKcqDonGiaNgoaiQuyCheService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKcqDonGiaNgoaiQuyCheDataSourceView used by the ViewKcqDonGiaNgoaiQuyCheDataSource.
		/// </summary>
		protected ViewKcqDonGiaNgoaiQuyCheDataSourceView ViewKcqDonGiaNgoaiQuyCheView
		{
			get { return ( View as ViewKcqDonGiaNgoaiQuyCheDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewKcqDonGiaNgoaiQuyCheDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewKcqDonGiaNgoaiQuyCheSelectMethod SelectMethod
		{
			get
			{
				ViewKcqDonGiaNgoaiQuyCheSelectMethod selectMethod = ViewKcqDonGiaNgoaiQuyCheSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewKcqDonGiaNgoaiQuyCheSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKcqDonGiaNgoaiQuyCheDataSourceView class that is to be
		/// used by the ViewKcqDonGiaNgoaiQuyCheDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKcqDonGiaNgoaiQuyCheDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKcqDonGiaNgoaiQuyChe, Object> GetNewDataSourceView()
		{
			return new ViewKcqDonGiaNgoaiQuyCheDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKcqDonGiaNgoaiQuyCheDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKcqDonGiaNgoaiQuyCheDataSourceView : ReadOnlyDataSourceView<ViewKcqDonGiaNgoaiQuyChe>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqDonGiaNgoaiQuyCheDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKcqDonGiaNgoaiQuyCheDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKcqDonGiaNgoaiQuyCheDataSourceView(ViewKcqDonGiaNgoaiQuyCheDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKcqDonGiaNgoaiQuyCheDataSource ViewKcqDonGiaNgoaiQuyCheOwner
		{
			get { return Owner as ViewKcqDonGiaNgoaiQuyCheDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewKcqDonGiaNgoaiQuyCheSelectMethod SelectMethod
		{
			get { return ViewKcqDonGiaNgoaiQuyCheOwner.SelectMethod; }
			set { ViewKcqDonGiaNgoaiQuyCheOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKcqDonGiaNgoaiQuyCheService ViewKcqDonGiaNgoaiQuyCheProvider
		{
			get { return Provider as ViewKcqDonGiaNgoaiQuyCheService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewKcqDonGiaNgoaiQuyChe> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewKcqDonGiaNgoaiQuyChe> results = null;
			// ViewKcqDonGiaNgoaiQuyChe item;
			count = 0;
			
			System.String sp3079_NamHoc;
			System.String sp3079_HocKy;

			switch ( SelectMethod )
			{
				case ViewKcqDonGiaNgoaiQuyCheSelectMethod.Get:
					results = ViewKcqDonGiaNgoaiQuyCheProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewKcqDonGiaNgoaiQuyCheSelectMethod.GetPaged:
					results = ViewKcqDonGiaNgoaiQuyCheProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewKcqDonGiaNgoaiQuyCheSelectMethod.GetAll:
					results = ViewKcqDonGiaNgoaiQuyCheProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewKcqDonGiaNgoaiQuyCheSelectMethod.Find:
					results = ViewKcqDonGiaNgoaiQuyCheProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewKcqDonGiaNgoaiQuyCheSelectMethod.GetByNamHocHocKy:
					sp3079_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3079_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewKcqDonGiaNgoaiQuyCheProvider.GetByNamHocHocKy(sp3079_NamHoc, sp3079_HocKy, StartIndex, PageSize);
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

	#region ViewKcqDonGiaNgoaiQuyCheSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewKcqDonGiaNgoaiQuyCheDataSource.SelectMethod property.
	/// </summary>
	public enum ViewKcqDonGiaNgoaiQuyCheSelectMethod
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
	
	#endregion ViewKcqDonGiaNgoaiQuyCheSelectMethod
	
	#region ViewKcqDonGiaNgoaiQuyCheDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKcqDonGiaNgoaiQuyCheDataSource class.
	/// </summary>
	public class ViewKcqDonGiaNgoaiQuyCheDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKcqDonGiaNgoaiQuyChe>
	{
		/// <summary>
		/// Initializes a new instance of the ViewKcqDonGiaNgoaiQuyCheDataSourceDesigner class.
		/// </summary>
		public ViewKcqDonGiaNgoaiQuyCheDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewKcqDonGiaNgoaiQuyCheSelectMethod SelectMethod
		{
			get { return ((ViewKcqDonGiaNgoaiQuyCheDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewKcqDonGiaNgoaiQuyCheDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewKcqDonGiaNgoaiQuyCheDataSourceActionList

	/// <summary>
	/// Supports the ViewKcqDonGiaNgoaiQuyCheDataSourceDesigner class.
	/// </summary>
	internal class ViewKcqDonGiaNgoaiQuyCheDataSourceActionList : DesignerActionList
	{
		private ViewKcqDonGiaNgoaiQuyCheDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewKcqDonGiaNgoaiQuyCheDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewKcqDonGiaNgoaiQuyCheDataSourceActionList(ViewKcqDonGiaNgoaiQuyCheDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewKcqDonGiaNgoaiQuyCheSelectMethod SelectMethod
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

	#endregion ViewKcqDonGiaNgoaiQuyCheDataSourceActionList

	#endregion ViewKcqDonGiaNgoaiQuyCheDataSourceDesigner

	#region ViewKcqDonGiaNgoaiQuyCheFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqDonGiaNgoaiQuyChe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqDonGiaNgoaiQuyCheFilter : SqlFilter<ViewKcqDonGiaNgoaiQuyCheColumn>
	{
	}

	#endregion ViewKcqDonGiaNgoaiQuyCheFilter

	#region ViewKcqDonGiaNgoaiQuyCheExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqDonGiaNgoaiQuyChe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqDonGiaNgoaiQuyCheExpressionBuilder : SqlExpressionBuilder<ViewKcqDonGiaNgoaiQuyCheColumn>
	{
	}
	
	#endregion ViewKcqDonGiaNgoaiQuyCheExpressionBuilder		
}

