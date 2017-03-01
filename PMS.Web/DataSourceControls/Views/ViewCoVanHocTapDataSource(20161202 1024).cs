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
	/// Represents the DataRepository.ViewCoVanHocTapProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewCoVanHocTapDataSourceDesigner))]
	public class ViewCoVanHocTapDataSource : ReadOnlyDataSource<ViewCoVanHocTap>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewCoVanHocTapDataSource class.
		/// </summary>
		public ViewCoVanHocTapDataSource() : base(new ViewCoVanHocTapService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewCoVanHocTapDataSourceView used by the ViewCoVanHocTapDataSource.
		/// </summary>
		protected ViewCoVanHocTapDataSourceView ViewCoVanHocTapView
		{
			get { return ( View as ViewCoVanHocTapDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewCoVanHocTapDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewCoVanHocTapSelectMethod SelectMethod
		{
			get
			{
				ViewCoVanHocTapSelectMethod selectMethod = ViewCoVanHocTapSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewCoVanHocTapSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewCoVanHocTapDataSourceView class that is to be
		/// used by the ViewCoVanHocTapDataSource.
		/// </summary>
		/// <returns>An instance of the ViewCoVanHocTapDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewCoVanHocTap, Object> GetNewDataSourceView()
		{
			return new ViewCoVanHocTapDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewCoVanHocTapDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewCoVanHocTapDataSourceView : ReadOnlyDataSourceView<ViewCoVanHocTap>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewCoVanHocTapDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewCoVanHocTapDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewCoVanHocTapDataSourceView(ViewCoVanHocTapDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewCoVanHocTapDataSource ViewCoVanHocTapOwner
		{
			get { return Owner as ViewCoVanHocTapDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewCoVanHocTapSelectMethod SelectMethod
		{
			get { return ViewCoVanHocTapOwner.SelectMethod; }
			set { ViewCoVanHocTapOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewCoVanHocTapService ViewCoVanHocTapProvider
		{
			get { return Provider as ViewCoVanHocTapService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewCoVanHocTap> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewCoVanHocTap> results = null;
			// ViewCoVanHocTap item;
			count = 0;
			
			System.String sp3041_NamHoc;
			System.String sp3041_HocKy;

			switch ( SelectMethod )
			{
				case ViewCoVanHocTapSelectMethod.Get:
					results = ViewCoVanHocTapProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewCoVanHocTapSelectMethod.GetPaged:
					results = ViewCoVanHocTapProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewCoVanHocTapSelectMethod.GetAll:
					results = ViewCoVanHocTapProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewCoVanHocTapSelectMethod.Find:
					results = ViewCoVanHocTapProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewCoVanHocTapSelectMethod.GetByNamHocHocKy:
					sp3041_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3041_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewCoVanHocTapProvider.GetByNamHocHocKy(sp3041_NamHoc, sp3041_HocKy, StartIndex, PageSize);
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

	#region ViewCoVanHocTapSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewCoVanHocTapDataSource.SelectMethod property.
	/// </summary>
	public enum ViewCoVanHocTapSelectMethod
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
	
	#endregion ViewCoVanHocTapSelectMethod
	
	#region ViewCoVanHocTapDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewCoVanHocTapDataSource class.
	/// </summary>
	public class ViewCoVanHocTapDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewCoVanHocTap>
	{
		/// <summary>
		/// Initializes a new instance of the ViewCoVanHocTapDataSourceDesigner class.
		/// </summary>
		public ViewCoVanHocTapDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewCoVanHocTapSelectMethod SelectMethod
		{
			get { return ((ViewCoVanHocTapDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewCoVanHocTapDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewCoVanHocTapDataSourceActionList

	/// <summary>
	/// Supports the ViewCoVanHocTapDataSourceDesigner class.
	/// </summary>
	internal class ViewCoVanHocTapDataSourceActionList : DesignerActionList
	{
		private ViewCoVanHocTapDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewCoVanHocTapDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewCoVanHocTapDataSourceActionList(ViewCoVanHocTapDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewCoVanHocTapSelectMethod SelectMethod
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

	#endregion ViewCoVanHocTapDataSourceActionList

	#endregion ViewCoVanHocTapDataSourceDesigner

	#region ViewCoVanHocTapFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewCoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewCoVanHocTapFilter : SqlFilter<ViewCoVanHocTapColumn>
	{
	}

	#endregion ViewCoVanHocTapFilter

	#region ViewCoVanHocTapExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewCoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewCoVanHocTapExpressionBuilder : SqlExpressionBuilder<ViewCoVanHocTapColumn>
	{
	}
	
	#endregion ViewCoVanHocTapExpressionBuilder		
}

