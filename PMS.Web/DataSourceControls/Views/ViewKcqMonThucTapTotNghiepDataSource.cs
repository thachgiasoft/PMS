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
	/// Represents the DataRepository.ViewKcqMonThucTapTotNghiepProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKcqMonThucTapTotNghiepDataSourceDesigner))]
	public class ViewKcqMonThucTapTotNghiepDataSource : ReadOnlyDataSource<ViewKcqMonThucTapTotNghiep>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonThucTapTotNghiepDataSource class.
		/// </summary>
		public ViewKcqMonThucTapTotNghiepDataSource() : base(new ViewKcqMonThucTapTotNghiepService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKcqMonThucTapTotNghiepDataSourceView used by the ViewKcqMonThucTapTotNghiepDataSource.
		/// </summary>
		protected ViewKcqMonThucTapTotNghiepDataSourceView ViewKcqMonThucTapTotNghiepView
		{
			get { return ( View as ViewKcqMonThucTapTotNghiepDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewKcqMonThucTapTotNghiepDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewKcqMonThucTapTotNghiepSelectMethod SelectMethod
		{
			get
			{
				ViewKcqMonThucTapTotNghiepSelectMethod selectMethod = ViewKcqMonThucTapTotNghiepSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewKcqMonThucTapTotNghiepSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKcqMonThucTapTotNghiepDataSourceView class that is to be
		/// used by the ViewKcqMonThucTapTotNghiepDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKcqMonThucTapTotNghiepDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKcqMonThucTapTotNghiep, Object> GetNewDataSourceView()
		{
			return new ViewKcqMonThucTapTotNghiepDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKcqMonThucTapTotNghiepDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKcqMonThucTapTotNghiepDataSourceView : ReadOnlyDataSourceView<ViewKcqMonThucTapTotNghiep>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonThucTapTotNghiepDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKcqMonThucTapTotNghiepDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKcqMonThucTapTotNghiepDataSourceView(ViewKcqMonThucTapTotNghiepDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKcqMonThucTapTotNghiepDataSource ViewKcqMonThucTapTotNghiepOwner
		{
			get { return Owner as ViewKcqMonThucTapTotNghiepDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewKcqMonThucTapTotNghiepSelectMethod SelectMethod
		{
			get { return ViewKcqMonThucTapTotNghiepOwner.SelectMethod; }
			set { ViewKcqMonThucTapTotNghiepOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKcqMonThucTapTotNghiepService ViewKcqMonThucTapTotNghiepProvider
		{
			get { return Provider as ViewKcqMonThucTapTotNghiepService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewKcqMonThucTapTotNghiep> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewKcqMonThucTapTotNghiep> results = null;
			// ViewKcqMonThucTapTotNghiep item;
			count = 0;
			
			System.String sp988_NamHoc;
			System.String sp988_HocKy;

			switch ( SelectMethod )
			{
				case ViewKcqMonThucTapTotNghiepSelectMethod.Get:
					results = ViewKcqMonThucTapTotNghiepProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewKcqMonThucTapTotNghiepSelectMethod.GetPaged:
					results = ViewKcqMonThucTapTotNghiepProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewKcqMonThucTapTotNghiepSelectMethod.GetAll:
					results = ViewKcqMonThucTapTotNghiepProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewKcqMonThucTapTotNghiepSelectMethod.Find:
					results = ViewKcqMonThucTapTotNghiepProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewKcqMonThucTapTotNghiepSelectMethod.GetByNamHocHocKy:
					sp988_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp988_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewKcqMonThucTapTotNghiepProvider.GetByNamHocHocKy(sp988_NamHoc, sp988_HocKy, StartIndex, PageSize);
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

	#region ViewKcqMonThucTapTotNghiepSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewKcqMonThucTapTotNghiepDataSource.SelectMethod property.
	/// </summary>
	public enum ViewKcqMonThucTapTotNghiepSelectMethod
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
	
	#endregion ViewKcqMonThucTapTotNghiepSelectMethod
	
	#region ViewKcqMonThucTapTotNghiepDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKcqMonThucTapTotNghiepDataSource class.
	/// </summary>
	public class ViewKcqMonThucTapTotNghiepDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKcqMonThucTapTotNghiep>
	{
		/// <summary>
		/// Initializes a new instance of the ViewKcqMonThucTapTotNghiepDataSourceDesigner class.
		/// </summary>
		public ViewKcqMonThucTapTotNghiepDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewKcqMonThucTapTotNghiepSelectMethod SelectMethod
		{
			get { return ((ViewKcqMonThucTapTotNghiepDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewKcqMonThucTapTotNghiepDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewKcqMonThucTapTotNghiepDataSourceActionList

	/// <summary>
	/// Supports the ViewKcqMonThucTapTotNghiepDataSourceDesigner class.
	/// </summary>
	internal class ViewKcqMonThucTapTotNghiepDataSourceActionList : DesignerActionList
	{
		private ViewKcqMonThucTapTotNghiepDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewKcqMonThucTapTotNghiepDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewKcqMonThucTapTotNghiepDataSourceActionList(ViewKcqMonThucTapTotNghiepDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewKcqMonThucTapTotNghiepSelectMethod SelectMethod
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

	#endregion ViewKcqMonThucTapTotNghiepDataSourceActionList

	#endregion ViewKcqMonThucTapTotNghiepDataSourceDesigner

	#region ViewKcqMonThucTapTotNghiepFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqMonThucTapTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqMonThucTapTotNghiepFilter : SqlFilter<ViewKcqMonThucTapTotNghiepColumn>
	{
	}

	#endregion ViewKcqMonThucTapTotNghiepFilter

	#region ViewKcqMonThucTapTotNghiepExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqMonThucTapTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqMonThucTapTotNghiepExpressionBuilder : SqlExpressionBuilder<ViewKcqMonThucTapTotNghiepColumn>
	{
	}
	
	#endregion ViewKcqMonThucTapTotNghiepExpressionBuilder		
}

