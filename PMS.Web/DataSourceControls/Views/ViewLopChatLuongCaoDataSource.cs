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
	/// Represents the DataRepository.ViewLopChatLuongCaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewLopChatLuongCaoDataSourceDesigner))]
	public class ViewLopChatLuongCaoDataSource : ReadOnlyDataSource<ViewLopChatLuongCao>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopChatLuongCaoDataSource class.
		/// </summary>
		public ViewLopChatLuongCaoDataSource() : base(new ViewLopChatLuongCaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewLopChatLuongCaoDataSourceView used by the ViewLopChatLuongCaoDataSource.
		/// </summary>
		protected ViewLopChatLuongCaoDataSourceView ViewLopChatLuongCaoView
		{
			get { return ( View as ViewLopChatLuongCaoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewLopChatLuongCaoDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewLopChatLuongCaoSelectMethod SelectMethod
		{
			get
			{
				ViewLopChatLuongCaoSelectMethod selectMethod = ViewLopChatLuongCaoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewLopChatLuongCaoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewLopChatLuongCaoDataSourceView class that is to be
		/// used by the ViewLopChatLuongCaoDataSource.
		/// </summary>
		/// <returns>An instance of the ViewLopChatLuongCaoDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewLopChatLuongCao, Object> GetNewDataSourceView()
		{
			return new ViewLopChatLuongCaoDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewLopChatLuongCaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewLopChatLuongCaoDataSourceView : ReadOnlyDataSourceView<ViewLopChatLuongCao>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopChatLuongCaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewLopChatLuongCaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewLopChatLuongCaoDataSourceView(ViewLopChatLuongCaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewLopChatLuongCaoDataSource ViewLopChatLuongCaoOwner
		{
			get { return Owner as ViewLopChatLuongCaoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewLopChatLuongCaoSelectMethod SelectMethod
		{
			get { return ViewLopChatLuongCaoOwner.SelectMethod; }
			set { ViewLopChatLuongCaoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewLopChatLuongCaoService ViewLopChatLuongCaoProvider
		{
			get { return Provider as ViewLopChatLuongCaoService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewLopChatLuongCao> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewLopChatLuongCao> results = null;
			// ViewLopChatLuongCao item;
			count = 0;
			
			System.String sp1042_NamHoc;

			switch ( SelectMethod )
			{
				case ViewLopChatLuongCaoSelectMethod.Get:
					results = ViewLopChatLuongCaoProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewLopChatLuongCaoSelectMethod.GetPaged:
					results = ViewLopChatLuongCaoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewLopChatLuongCaoSelectMethod.GetAll:
					results = ViewLopChatLuongCaoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewLopChatLuongCaoSelectMethod.Find:
					results = ViewLopChatLuongCaoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewLopChatLuongCaoSelectMethod.GetByNamHoc:
					sp1042_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					results = ViewLopChatLuongCaoProvider.GetByNamHoc(sp1042_NamHoc, StartIndex, PageSize);
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

	#region ViewLopChatLuongCaoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewLopChatLuongCaoDataSource.SelectMethod property.
	/// </summary>
	public enum ViewLopChatLuongCaoSelectMethod
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
	
	#endregion ViewLopChatLuongCaoSelectMethod
	
	#region ViewLopChatLuongCaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewLopChatLuongCaoDataSource class.
	/// </summary>
	public class ViewLopChatLuongCaoDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewLopChatLuongCao>
	{
		/// <summary>
		/// Initializes a new instance of the ViewLopChatLuongCaoDataSourceDesigner class.
		/// </summary>
		public ViewLopChatLuongCaoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewLopChatLuongCaoSelectMethod SelectMethod
		{
			get { return ((ViewLopChatLuongCaoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewLopChatLuongCaoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewLopChatLuongCaoDataSourceActionList

	/// <summary>
	/// Supports the ViewLopChatLuongCaoDataSourceDesigner class.
	/// </summary>
	internal class ViewLopChatLuongCaoDataSourceActionList : DesignerActionList
	{
		private ViewLopChatLuongCaoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewLopChatLuongCaoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewLopChatLuongCaoDataSourceActionList(ViewLopChatLuongCaoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewLopChatLuongCaoSelectMethod SelectMethod
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

	#endregion ViewLopChatLuongCaoDataSourceActionList

	#endregion ViewLopChatLuongCaoDataSourceDesigner

	#region ViewLopChatLuongCaoFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopChatLuongCao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopChatLuongCaoFilter : SqlFilter<ViewLopChatLuongCaoColumn>
	{
	}

	#endregion ViewLopChatLuongCaoFilter

	#region ViewLopChatLuongCaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopChatLuongCao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopChatLuongCaoExpressionBuilder : SqlExpressionBuilder<ViewLopChatLuongCaoColumn>
	{
	}
	
	#endregion ViewLopChatLuongCaoExpressionBuilder		
}

