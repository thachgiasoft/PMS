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
	/// Represents the DataRepository.ViewHocPhanMonHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewHocPhanMonHocDataSourceDesigner))]
	public class ViewHocPhanMonHocDataSource : ReadOnlyDataSource<ViewHocPhanMonHoc>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHocPhanMonHocDataSource class.
		/// </summary>
		public ViewHocPhanMonHocDataSource() : base(new ViewHocPhanMonHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewHocPhanMonHocDataSourceView used by the ViewHocPhanMonHocDataSource.
		/// </summary>
		protected ViewHocPhanMonHocDataSourceView ViewHocPhanMonHocView
		{
			get { return ( View as ViewHocPhanMonHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewHocPhanMonHocDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewHocPhanMonHocSelectMethod SelectMethod
		{
			get
			{
				ViewHocPhanMonHocSelectMethod selectMethod = ViewHocPhanMonHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewHocPhanMonHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewHocPhanMonHocDataSourceView class that is to be
		/// used by the ViewHocPhanMonHocDataSource.
		/// </summary>
		/// <returns>An instance of the ViewHocPhanMonHocDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewHocPhanMonHoc, Object> GetNewDataSourceView()
		{
			return new ViewHocPhanMonHocDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewHocPhanMonHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewHocPhanMonHocDataSourceView : ReadOnlyDataSourceView<ViewHocPhanMonHoc>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHocPhanMonHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewHocPhanMonHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewHocPhanMonHocDataSourceView(ViewHocPhanMonHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewHocPhanMonHocDataSource ViewHocPhanMonHocOwner
		{
			get { return Owner as ViewHocPhanMonHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewHocPhanMonHocSelectMethod SelectMethod
		{
			get { return ViewHocPhanMonHocOwner.SelectMethod; }
			set { ViewHocPhanMonHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewHocPhanMonHocService ViewHocPhanMonHocProvider
		{
			get { return Provider as ViewHocPhanMonHocService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewHocPhanMonHoc> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewHocPhanMonHoc> results = null;
			// ViewHocPhanMonHoc item;
			count = 0;
			
			System.String sp3077_NamHoc;
			System.String sp3077_HocKy;

			switch ( SelectMethod )
			{
				case ViewHocPhanMonHocSelectMethod.Get:
					results = ViewHocPhanMonHocProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewHocPhanMonHocSelectMethod.GetPaged:
					results = ViewHocPhanMonHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewHocPhanMonHocSelectMethod.GetAll:
					results = ViewHocPhanMonHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewHocPhanMonHocSelectMethod.Find:
					results = ViewHocPhanMonHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewHocPhanMonHocSelectMethod.GetByNamHocHocKy:
					sp3077_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3077_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewHocPhanMonHocProvider.GetByNamHocHocKy(sp3077_NamHoc, sp3077_HocKy, StartIndex, PageSize);
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

	#region ViewHocPhanMonHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewHocPhanMonHocDataSource.SelectMethod property.
	/// </summary>
	public enum ViewHocPhanMonHocSelectMethod
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
	
	#endregion ViewHocPhanMonHocSelectMethod
	
	#region ViewHocPhanMonHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewHocPhanMonHocDataSource class.
	/// </summary>
	public class ViewHocPhanMonHocDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewHocPhanMonHoc>
	{
		/// <summary>
		/// Initializes a new instance of the ViewHocPhanMonHocDataSourceDesigner class.
		/// </summary>
		public ViewHocPhanMonHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewHocPhanMonHocSelectMethod SelectMethod
		{
			get { return ((ViewHocPhanMonHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewHocPhanMonHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewHocPhanMonHocDataSourceActionList

	/// <summary>
	/// Supports the ViewHocPhanMonHocDataSourceDesigner class.
	/// </summary>
	internal class ViewHocPhanMonHocDataSourceActionList : DesignerActionList
	{
		private ViewHocPhanMonHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewHocPhanMonHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewHocPhanMonHocDataSourceActionList(ViewHocPhanMonHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewHocPhanMonHocSelectMethod SelectMethod
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

	#endregion ViewHocPhanMonHocDataSourceActionList

	#endregion ViewHocPhanMonHocDataSourceDesigner

	#region ViewHocPhanMonHocFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHocPhanMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHocPhanMonHocFilter : SqlFilter<ViewHocPhanMonHocColumn>
	{
	}

	#endregion ViewHocPhanMonHocFilter

	#region ViewHocPhanMonHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHocPhanMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHocPhanMonHocExpressionBuilder : SqlExpressionBuilder<ViewHocPhanMonHocColumn>
	{
	}
	
	#endregion ViewHocPhanMonHocExpressionBuilder		
}

