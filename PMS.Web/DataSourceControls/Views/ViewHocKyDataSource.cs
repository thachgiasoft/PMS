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
	/// Represents the DataRepository.ViewHocKyProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewHocKyDataSourceDesigner))]
	public class ViewHocKyDataSource : ReadOnlyDataSource<ViewHocKy>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHocKyDataSource class.
		/// </summary>
		public ViewHocKyDataSource() : base(new ViewHocKyService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewHocKyDataSourceView used by the ViewHocKyDataSource.
		/// </summary>
		protected ViewHocKyDataSourceView ViewHocKyView
		{
			get { return ( View as ViewHocKyDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewHocKyDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewHocKySelectMethod SelectMethod
		{
			get
			{
				ViewHocKySelectMethod selectMethod = ViewHocKySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewHocKySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewHocKyDataSourceView class that is to be
		/// used by the ViewHocKyDataSource.
		/// </summary>
		/// <returns>An instance of the ViewHocKyDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewHocKy, Object> GetNewDataSourceView()
		{
			return new ViewHocKyDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewHocKyDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewHocKyDataSourceView : ReadOnlyDataSourceView<ViewHocKy>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHocKyDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewHocKyDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewHocKyDataSourceView(ViewHocKyDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewHocKyDataSource ViewHocKyOwner
		{
			get { return Owner as ViewHocKyDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewHocKySelectMethod SelectMethod
		{
			get { return ViewHocKyOwner.SelectMethod; }
			set { ViewHocKyOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewHocKyService ViewHocKyProvider
		{
			get { return Provider as ViewHocKyService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewHocKy> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewHocKy> results = null;
			// ViewHocKy item;
			count = 0;
			
			System.String sp976_NamHoc;

			switch ( SelectMethod )
			{
				case ViewHocKySelectMethod.Get:
					results = ViewHocKyProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewHocKySelectMethod.GetPaged:
					results = ViewHocKyProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewHocKySelectMethod.GetAll:
					results = ViewHocKyProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewHocKySelectMethod.Find:
					results = ViewHocKyProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewHocKySelectMethod.GetByNamHoc:
					sp976_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					results = ViewHocKyProvider.GetByNamHoc(sp976_NamHoc, StartIndex, PageSize);
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

	#region ViewHocKySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewHocKyDataSource.SelectMethod property.
	/// </summary>
	public enum ViewHocKySelectMethod
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
		/// Represents the GetByNamHoc method.
		/// </summary>
		GetByNamHoc
	}
	
	#endregion ViewHocKySelectMethod
	
	#region ViewHocKyDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewHocKyDataSource class.
	/// </summary>
	public class ViewHocKyDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewHocKy>
	{
		/// <summary>
		/// Initializes a new instance of the ViewHocKyDataSourceDesigner class.
		/// </summary>
		public ViewHocKyDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewHocKySelectMethod SelectMethod
		{
			get { return ((ViewHocKyDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewHocKyDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewHocKyDataSourceActionList

	/// <summary>
	/// Supports the ViewHocKyDataSourceDesigner class.
	/// </summary>
	internal class ViewHocKyDataSourceActionList : DesignerActionList
	{
		private ViewHocKyDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewHocKyDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewHocKyDataSourceActionList(ViewHocKyDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewHocKySelectMethod SelectMethod
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

	#endregion ViewHocKyDataSourceActionList

	#endregion ViewHocKyDataSourceDesigner

	#region ViewHocKyFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHocKyFilter : SqlFilter<ViewHocKyColumn>
	{
	}

	#endregion ViewHocKyFilter

	#region ViewHocKyExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHocKyExpressionBuilder : SqlExpressionBuilder<ViewHocKyColumn>
	{
	}
	
	#endregion ViewHocKyExpressionBuilder		
}

