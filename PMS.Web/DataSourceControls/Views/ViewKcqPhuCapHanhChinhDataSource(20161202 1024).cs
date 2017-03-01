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
	/// Represents the DataRepository.ViewKcqPhuCapHanhChinhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKcqPhuCapHanhChinhDataSourceDesigner))]
	public class ViewKcqPhuCapHanhChinhDataSource : ReadOnlyDataSource<ViewKcqPhuCapHanhChinh>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhuCapHanhChinhDataSource class.
		/// </summary>
		public ViewKcqPhuCapHanhChinhDataSource() : base(new ViewKcqPhuCapHanhChinhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKcqPhuCapHanhChinhDataSourceView used by the ViewKcqPhuCapHanhChinhDataSource.
		/// </summary>
		protected ViewKcqPhuCapHanhChinhDataSourceView ViewKcqPhuCapHanhChinhView
		{
			get { return ( View as ViewKcqPhuCapHanhChinhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewKcqPhuCapHanhChinhDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewKcqPhuCapHanhChinhSelectMethod SelectMethod
		{
			get
			{
				ViewKcqPhuCapHanhChinhSelectMethod selectMethod = ViewKcqPhuCapHanhChinhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewKcqPhuCapHanhChinhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKcqPhuCapHanhChinhDataSourceView class that is to be
		/// used by the ViewKcqPhuCapHanhChinhDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKcqPhuCapHanhChinhDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKcqPhuCapHanhChinh, Object> GetNewDataSourceView()
		{
			return new ViewKcqPhuCapHanhChinhDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKcqPhuCapHanhChinhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKcqPhuCapHanhChinhDataSourceView : ReadOnlyDataSourceView<ViewKcqPhuCapHanhChinh>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhuCapHanhChinhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKcqPhuCapHanhChinhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKcqPhuCapHanhChinhDataSourceView(ViewKcqPhuCapHanhChinhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKcqPhuCapHanhChinhDataSource ViewKcqPhuCapHanhChinhOwner
		{
			get { return Owner as ViewKcqPhuCapHanhChinhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewKcqPhuCapHanhChinhSelectMethod SelectMethod
		{
			get { return ViewKcqPhuCapHanhChinhOwner.SelectMethod; }
			set { ViewKcqPhuCapHanhChinhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKcqPhuCapHanhChinhService ViewKcqPhuCapHanhChinhProvider
		{
			get { return Provider as ViewKcqPhuCapHanhChinhService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewKcqPhuCapHanhChinh> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewKcqPhuCapHanhChinh> results = null;
			// ViewKcqPhuCapHanhChinh item;
			count = 0;
			
			System.String sp3090_NamHoc;
			System.String sp3090_HocKy;

			switch ( SelectMethod )
			{
				case ViewKcqPhuCapHanhChinhSelectMethod.Get:
					results = ViewKcqPhuCapHanhChinhProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewKcqPhuCapHanhChinhSelectMethod.GetPaged:
					results = ViewKcqPhuCapHanhChinhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewKcqPhuCapHanhChinhSelectMethod.GetAll:
					results = ViewKcqPhuCapHanhChinhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewKcqPhuCapHanhChinhSelectMethod.Find:
					results = ViewKcqPhuCapHanhChinhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewKcqPhuCapHanhChinhSelectMethod.GetByNamHocHocKy:
					sp3090_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3090_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewKcqPhuCapHanhChinhProvider.GetByNamHocHocKy(sp3090_NamHoc, sp3090_HocKy, StartIndex, PageSize);
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

	#region ViewKcqPhuCapHanhChinhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewKcqPhuCapHanhChinhDataSource.SelectMethod property.
	/// </summary>
	public enum ViewKcqPhuCapHanhChinhSelectMethod
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
	
	#endregion ViewKcqPhuCapHanhChinhSelectMethod
	
	#region ViewKcqPhuCapHanhChinhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKcqPhuCapHanhChinhDataSource class.
	/// </summary>
	public class ViewKcqPhuCapHanhChinhDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKcqPhuCapHanhChinh>
	{
		/// <summary>
		/// Initializes a new instance of the ViewKcqPhuCapHanhChinhDataSourceDesigner class.
		/// </summary>
		public ViewKcqPhuCapHanhChinhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewKcqPhuCapHanhChinhSelectMethod SelectMethod
		{
			get { return ((ViewKcqPhuCapHanhChinhDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewKcqPhuCapHanhChinhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewKcqPhuCapHanhChinhDataSourceActionList

	/// <summary>
	/// Supports the ViewKcqPhuCapHanhChinhDataSourceDesigner class.
	/// </summary>
	internal class ViewKcqPhuCapHanhChinhDataSourceActionList : DesignerActionList
	{
		private ViewKcqPhuCapHanhChinhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhuCapHanhChinhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewKcqPhuCapHanhChinhDataSourceActionList(ViewKcqPhuCapHanhChinhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewKcqPhuCapHanhChinhSelectMethod SelectMethod
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

	#endregion ViewKcqPhuCapHanhChinhDataSourceActionList

	#endregion ViewKcqPhuCapHanhChinhDataSourceDesigner

	#region ViewKcqPhuCapHanhChinhFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqPhuCapHanhChinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqPhuCapHanhChinhFilter : SqlFilter<ViewKcqPhuCapHanhChinhColumn>
	{
	}

	#endregion ViewKcqPhuCapHanhChinhFilter

	#region ViewKcqPhuCapHanhChinhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqPhuCapHanhChinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqPhuCapHanhChinhExpressionBuilder : SqlExpressionBuilder<ViewKcqPhuCapHanhChinhColumn>
	{
	}
	
	#endregion ViewKcqPhuCapHanhChinhExpressionBuilder		
}

