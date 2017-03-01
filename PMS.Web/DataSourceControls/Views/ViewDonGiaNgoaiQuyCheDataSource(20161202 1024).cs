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
	/// Represents the DataRepository.ViewDonGiaNgoaiQuyCheProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewDonGiaNgoaiQuyCheDataSourceDesigner))]
	public class ViewDonGiaNgoaiQuyCheDataSource : ReadOnlyDataSource<ViewDonGiaNgoaiQuyChe>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDonGiaNgoaiQuyCheDataSource class.
		/// </summary>
		public ViewDonGiaNgoaiQuyCheDataSource() : base(new ViewDonGiaNgoaiQuyCheService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewDonGiaNgoaiQuyCheDataSourceView used by the ViewDonGiaNgoaiQuyCheDataSource.
		/// </summary>
		protected ViewDonGiaNgoaiQuyCheDataSourceView ViewDonGiaNgoaiQuyCheView
		{
			get { return ( View as ViewDonGiaNgoaiQuyCheDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewDonGiaNgoaiQuyCheDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewDonGiaNgoaiQuyCheSelectMethod SelectMethod
		{
			get
			{
				ViewDonGiaNgoaiQuyCheSelectMethod selectMethod = ViewDonGiaNgoaiQuyCheSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewDonGiaNgoaiQuyCheSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewDonGiaNgoaiQuyCheDataSourceView class that is to be
		/// used by the ViewDonGiaNgoaiQuyCheDataSource.
		/// </summary>
		/// <returns>An instance of the ViewDonGiaNgoaiQuyCheDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewDonGiaNgoaiQuyChe, Object> GetNewDataSourceView()
		{
			return new ViewDonGiaNgoaiQuyCheDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewDonGiaNgoaiQuyCheDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewDonGiaNgoaiQuyCheDataSourceView : ReadOnlyDataSourceView<ViewDonGiaNgoaiQuyChe>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDonGiaNgoaiQuyCheDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewDonGiaNgoaiQuyCheDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewDonGiaNgoaiQuyCheDataSourceView(ViewDonGiaNgoaiQuyCheDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewDonGiaNgoaiQuyCheDataSource ViewDonGiaNgoaiQuyCheOwner
		{
			get { return Owner as ViewDonGiaNgoaiQuyCheDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewDonGiaNgoaiQuyCheSelectMethod SelectMethod
		{
			get { return ViewDonGiaNgoaiQuyCheOwner.SelectMethod; }
			set { ViewDonGiaNgoaiQuyCheOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewDonGiaNgoaiQuyCheService ViewDonGiaNgoaiQuyCheProvider
		{
			get { return Provider as ViewDonGiaNgoaiQuyCheService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewDonGiaNgoaiQuyChe> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewDonGiaNgoaiQuyChe> results = null;
			// ViewDonGiaNgoaiQuyChe item;
			count = 0;
			
			System.String sp3048_NamHoc;
			System.String sp3048_HocKy;

			switch ( SelectMethod )
			{
				case ViewDonGiaNgoaiQuyCheSelectMethod.Get:
					results = ViewDonGiaNgoaiQuyCheProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewDonGiaNgoaiQuyCheSelectMethod.GetPaged:
					results = ViewDonGiaNgoaiQuyCheProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewDonGiaNgoaiQuyCheSelectMethod.GetAll:
					results = ViewDonGiaNgoaiQuyCheProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewDonGiaNgoaiQuyCheSelectMethod.Find:
					results = ViewDonGiaNgoaiQuyCheProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewDonGiaNgoaiQuyCheSelectMethod.GetByNamHocHocKy:
					sp3048_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3048_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewDonGiaNgoaiQuyCheProvider.GetByNamHocHocKy(sp3048_NamHoc, sp3048_HocKy, StartIndex, PageSize);
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

	#region ViewDonGiaNgoaiQuyCheSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewDonGiaNgoaiQuyCheDataSource.SelectMethod property.
	/// </summary>
	public enum ViewDonGiaNgoaiQuyCheSelectMethod
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
	
	#endregion ViewDonGiaNgoaiQuyCheSelectMethod
	
	#region ViewDonGiaNgoaiQuyCheDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewDonGiaNgoaiQuyCheDataSource class.
	/// </summary>
	public class ViewDonGiaNgoaiQuyCheDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewDonGiaNgoaiQuyChe>
	{
		/// <summary>
		/// Initializes a new instance of the ViewDonGiaNgoaiQuyCheDataSourceDesigner class.
		/// </summary>
		public ViewDonGiaNgoaiQuyCheDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewDonGiaNgoaiQuyCheSelectMethod SelectMethod
		{
			get { return ((ViewDonGiaNgoaiQuyCheDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewDonGiaNgoaiQuyCheDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewDonGiaNgoaiQuyCheDataSourceActionList

	/// <summary>
	/// Supports the ViewDonGiaNgoaiQuyCheDataSourceDesigner class.
	/// </summary>
	internal class ViewDonGiaNgoaiQuyCheDataSourceActionList : DesignerActionList
	{
		private ViewDonGiaNgoaiQuyCheDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewDonGiaNgoaiQuyCheDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewDonGiaNgoaiQuyCheDataSourceActionList(ViewDonGiaNgoaiQuyCheDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewDonGiaNgoaiQuyCheSelectMethod SelectMethod
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

	#endregion ViewDonGiaNgoaiQuyCheDataSourceActionList

	#endregion ViewDonGiaNgoaiQuyCheDataSourceDesigner

	#region ViewDonGiaNgoaiQuyCheFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDonGiaNgoaiQuyChe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDonGiaNgoaiQuyCheFilter : SqlFilter<ViewDonGiaNgoaiQuyCheColumn>
	{
	}

	#endregion ViewDonGiaNgoaiQuyCheFilter

	#region ViewDonGiaNgoaiQuyCheExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDonGiaNgoaiQuyChe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDonGiaNgoaiQuyCheExpressionBuilder : SqlExpressionBuilder<ViewDonGiaNgoaiQuyCheColumn>
	{
	}
	
	#endregion ViewDonGiaNgoaiQuyCheExpressionBuilder		
}

