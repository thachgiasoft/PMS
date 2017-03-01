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
	/// Represents the DataRepository.ViewMonThucTapTotNghiepProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewMonThucTapTotNghiepDataSourceDesigner))]
	public class ViewMonThucTapTotNghiepDataSource : ReadOnlyDataSource<ViewMonThucTapTotNghiep>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewMonThucTapTotNghiepDataSource class.
		/// </summary>
		public ViewMonThucTapTotNghiepDataSource() : base(new ViewMonThucTapTotNghiepService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewMonThucTapTotNghiepDataSourceView used by the ViewMonThucTapTotNghiepDataSource.
		/// </summary>
		protected ViewMonThucTapTotNghiepDataSourceView ViewMonThucTapTotNghiepView
		{
			get { return ( View as ViewMonThucTapTotNghiepDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewMonThucTapTotNghiepDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewMonThucTapTotNghiepSelectMethod SelectMethod
		{
			get
			{
				ViewMonThucTapTotNghiepSelectMethod selectMethod = ViewMonThucTapTotNghiepSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewMonThucTapTotNghiepSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewMonThucTapTotNghiepDataSourceView class that is to be
		/// used by the ViewMonThucTapTotNghiepDataSource.
		/// </summary>
		/// <returns>An instance of the ViewMonThucTapTotNghiepDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewMonThucTapTotNghiep, Object> GetNewDataSourceView()
		{
			return new ViewMonThucTapTotNghiepDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewMonThucTapTotNghiepDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewMonThucTapTotNghiepDataSourceView : ReadOnlyDataSourceView<ViewMonThucTapTotNghiep>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewMonThucTapTotNghiepDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewMonThucTapTotNghiepDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewMonThucTapTotNghiepDataSourceView(ViewMonThucTapTotNghiepDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewMonThucTapTotNghiepDataSource ViewMonThucTapTotNghiepOwner
		{
			get { return Owner as ViewMonThucTapTotNghiepDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewMonThucTapTotNghiepSelectMethod SelectMethod
		{
			get { return ViewMonThucTapTotNghiepOwner.SelectMethod; }
			set { ViewMonThucTapTotNghiepOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewMonThucTapTotNghiepService ViewMonThucTapTotNghiepProvider
		{
			get { return Provider as ViewMonThucTapTotNghiepService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewMonThucTapTotNghiep> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewMonThucTapTotNghiep> results = null;
			// ViewMonThucTapTotNghiep item;
			count = 0;
			
			System.String sp3156_NamHoc;
			System.String sp3156_HocKy;

			switch ( SelectMethod )
			{
				case ViewMonThucTapTotNghiepSelectMethod.Get:
					results = ViewMonThucTapTotNghiepProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewMonThucTapTotNghiepSelectMethod.GetPaged:
					results = ViewMonThucTapTotNghiepProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewMonThucTapTotNghiepSelectMethod.GetAll:
					results = ViewMonThucTapTotNghiepProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewMonThucTapTotNghiepSelectMethod.Find:
					results = ViewMonThucTapTotNghiepProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewMonThucTapTotNghiepSelectMethod.GetByNamHocHocKy:
					sp3156_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3156_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewMonThucTapTotNghiepProvider.GetByNamHocHocKy(sp3156_NamHoc, sp3156_HocKy, StartIndex, PageSize);
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

	#region ViewMonThucTapTotNghiepSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewMonThucTapTotNghiepDataSource.SelectMethod property.
	/// </summary>
	public enum ViewMonThucTapTotNghiepSelectMethod
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
	
	#endregion ViewMonThucTapTotNghiepSelectMethod
	
	#region ViewMonThucTapTotNghiepDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewMonThucTapTotNghiepDataSource class.
	/// </summary>
	public class ViewMonThucTapTotNghiepDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewMonThucTapTotNghiep>
	{
		/// <summary>
		/// Initializes a new instance of the ViewMonThucTapTotNghiepDataSourceDesigner class.
		/// </summary>
		public ViewMonThucTapTotNghiepDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewMonThucTapTotNghiepSelectMethod SelectMethod
		{
			get { return ((ViewMonThucTapTotNghiepDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewMonThucTapTotNghiepDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewMonThucTapTotNghiepDataSourceActionList

	/// <summary>
	/// Supports the ViewMonThucTapTotNghiepDataSourceDesigner class.
	/// </summary>
	internal class ViewMonThucTapTotNghiepDataSourceActionList : DesignerActionList
	{
		private ViewMonThucTapTotNghiepDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewMonThucTapTotNghiepDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewMonThucTapTotNghiepDataSourceActionList(ViewMonThucTapTotNghiepDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewMonThucTapTotNghiepSelectMethod SelectMethod
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

	#endregion ViewMonThucTapTotNghiepDataSourceActionList

	#endregion ViewMonThucTapTotNghiepDataSourceDesigner

	#region ViewMonThucTapTotNghiepFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewMonThucTapTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewMonThucTapTotNghiepFilter : SqlFilter<ViewMonThucTapTotNghiepColumn>
	{
	}

	#endregion ViewMonThucTapTotNghiepFilter

	#region ViewMonThucTapTotNghiepExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewMonThucTapTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewMonThucTapTotNghiepExpressionBuilder : SqlExpressionBuilder<ViewMonThucTapTotNghiepColumn>
	{
	}
	
	#endregion ViewMonThucTapTotNghiepExpressionBuilder		
}

