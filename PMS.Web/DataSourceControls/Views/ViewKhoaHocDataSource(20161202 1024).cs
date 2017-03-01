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
	/// Represents the DataRepository.ViewKhoaHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKhoaHocDataSourceDesigner))]
	public class ViewKhoaHocDataSource : ReadOnlyDataSource<ViewKhoaHoc>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocDataSource class.
		/// </summary>
		public ViewKhoaHocDataSource() : base(new ViewKhoaHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKhoaHocDataSourceView used by the ViewKhoaHocDataSource.
		/// </summary>
		protected ViewKhoaHocDataSourceView ViewKhoaHocView
		{
			get { return ( View as ViewKhoaHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewKhoaHocDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewKhoaHocSelectMethod SelectMethod
		{
			get
			{
				ViewKhoaHocSelectMethod selectMethod = ViewKhoaHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewKhoaHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKhoaHocDataSourceView class that is to be
		/// used by the ViewKhoaHocDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKhoaHocDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKhoaHoc, Object> GetNewDataSourceView()
		{
			return new ViewKhoaHocDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKhoaHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKhoaHocDataSourceView : ReadOnlyDataSourceView<ViewKhoaHoc>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKhoaHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKhoaHocDataSourceView(ViewKhoaHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKhoaHocDataSource ViewKhoaHocOwner
		{
			get { return Owner as ViewKhoaHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewKhoaHocSelectMethod SelectMethod
		{
			get { return ViewKhoaHocOwner.SelectMethod; }
			set { ViewKhoaHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKhoaHocService ViewKhoaHocProvider
		{
			get { return Provider as ViewKhoaHocService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewKhoaHoc> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewKhoaHoc> results = null;
			// ViewKhoaHoc item;
			count = 0;
			
			System.String sp3112_MaBacDaoTao;

			switch ( SelectMethod )
			{
				case ViewKhoaHocSelectMethod.Get:
					results = ViewKhoaHocProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewKhoaHocSelectMethod.GetPaged:
					results = ViewKhoaHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewKhoaHocSelectMethod.GetAll:
					results = ViewKhoaHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewKhoaHocSelectMethod.Find:
					results = ViewKhoaHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewKhoaHocSelectMethod.GetByMaBacDaoTao:
					sp3112_MaBacDaoTao = (System.String) EntityUtil.ChangeType(values["MaBacDaoTao"], typeof(System.String));
					results = ViewKhoaHocProvider.GetByMaBacDaoTao(sp3112_MaBacDaoTao, StartIndex, PageSize);
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

	#region ViewKhoaHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewKhoaHocDataSource.SelectMethod property.
	/// </summary>
	public enum ViewKhoaHocSelectMethod
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
		/// Represents the GetByMaBacDaoTao method.
		/// </summary>
		GetByMaBacDaoTao
	}
	
	#endregion ViewKhoaHocSelectMethod
	
	#region ViewKhoaHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKhoaHocDataSource class.
	/// </summary>
	public class ViewKhoaHocDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKhoaHoc>
	{
		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocDataSourceDesigner class.
		/// </summary>
		public ViewKhoaHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewKhoaHocSelectMethod SelectMethod
		{
			get { return ((ViewKhoaHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewKhoaHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewKhoaHocDataSourceActionList

	/// <summary>
	/// Supports the ViewKhoaHocDataSourceDesigner class.
	/// </summary>
	internal class ViewKhoaHocDataSourceActionList : DesignerActionList
	{
		private ViewKhoaHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewKhoaHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewKhoaHocDataSourceActionList(ViewKhoaHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewKhoaHocSelectMethod SelectMethod
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

	#endregion ViewKhoaHocDataSourceActionList

	#endregion ViewKhoaHocDataSourceDesigner

	#region ViewKhoaHocFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoaHocFilter : SqlFilter<ViewKhoaHocColumn>
	{
	}

	#endregion ViewKhoaHocFilter

	#region ViewKhoaHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoaHocExpressionBuilder : SqlExpressionBuilder<ViewKhoaHocColumn>
	{
	}
	
	#endregion ViewKhoaHocExpressionBuilder		
}

