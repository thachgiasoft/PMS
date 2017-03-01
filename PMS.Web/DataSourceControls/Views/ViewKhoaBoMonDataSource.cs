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
	/// Represents the DataRepository.ViewKhoaBoMonProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKhoaBoMonDataSourceDesigner))]
	public class ViewKhoaBoMonDataSource : ReadOnlyDataSource<ViewKhoaBoMon>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaBoMonDataSource class.
		/// </summary>
		public ViewKhoaBoMonDataSource() : base(new ViewKhoaBoMonService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKhoaBoMonDataSourceView used by the ViewKhoaBoMonDataSource.
		/// </summary>
		protected ViewKhoaBoMonDataSourceView ViewKhoaBoMonView
		{
			get { return ( View as ViewKhoaBoMonDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewKhoaBoMonDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewKhoaBoMonSelectMethod SelectMethod
		{
			get
			{
				ViewKhoaBoMonSelectMethod selectMethod = ViewKhoaBoMonSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewKhoaBoMonSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKhoaBoMonDataSourceView class that is to be
		/// used by the ViewKhoaBoMonDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKhoaBoMonDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKhoaBoMon, Object> GetNewDataSourceView()
		{
			return new ViewKhoaBoMonDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKhoaBoMonDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKhoaBoMonDataSourceView : ReadOnlyDataSourceView<ViewKhoaBoMon>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoaBoMonDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKhoaBoMonDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKhoaBoMonDataSourceView(ViewKhoaBoMonDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKhoaBoMonDataSource ViewKhoaBoMonOwner
		{
			get { return Owner as ViewKhoaBoMonDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewKhoaBoMonSelectMethod SelectMethod
		{
			get { return ViewKhoaBoMonOwner.SelectMethod; }
			set { ViewKhoaBoMonOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKhoaBoMonService ViewKhoaBoMonProvider
		{
			get { return Provider as ViewKhoaBoMonService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewKhoaBoMon> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewKhoaBoMon> results = null;
			// ViewKhoaBoMon item;
			count = 0;
			
			System.String sp1009_CoSo;
			System.String sp1010_MaKhoa;
			System.String sp1008_MaBoMon;

			switch ( SelectMethod )
			{
				case ViewKhoaBoMonSelectMethod.Get:
					results = ViewKhoaBoMonProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewKhoaBoMonSelectMethod.GetPaged:
					results = ViewKhoaBoMonProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewKhoaBoMonSelectMethod.GetAll:
					results = ViewKhoaBoMonProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewKhoaBoMonSelectMethod.Find:
					results = ViewKhoaBoMonProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewKhoaBoMonSelectMethod.GetByMaCoSo:
					sp1009_CoSo = (System.String) EntityUtil.ChangeType(values["CoSo"], typeof(System.String));
					results = ViewKhoaBoMonProvider.GetByMaCoSo(sp1009_CoSo, StartIndex, PageSize);
					break;
				case ViewKhoaBoMonSelectMethod.GetByMaKhoa:
					sp1010_MaKhoa = (System.String) EntityUtil.ChangeType(values["MaKhoa"], typeof(System.String));
					results = ViewKhoaBoMonProvider.GetByMaKhoa(sp1010_MaKhoa, StartIndex, PageSize);
					break;
				case ViewKhoaBoMonSelectMethod.GetByMaBoMon:
					sp1008_MaBoMon = (System.String) EntityUtil.ChangeType(values["MaBoMon"], typeof(System.String));
					results = ViewKhoaBoMonProvider.GetByMaBoMon(sp1008_MaBoMon, StartIndex, PageSize);
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

	#region ViewKhoaBoMonSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewKhoaBoMonDataSource.SelectMethod property.
	/// </summary>
	public enum ViewKhoaBoMonSelectMethod
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
		/// Represents the GetByMaCoSo method.
		/// </summary>
		GetByMaCoSo,
		/// <summary>
		/// Represents the GetByMaKhoa method.
		/// </summary>
		GetByMaKhoa,
		/// <summary>
		/// Represents the GetByMaBoMon method.
		/// </summary>
		GetByMaBoMon
	}
	
	#endregion ViewKhoaBoMonSelectMethod
	
	#region ViewKhoaBoMonDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKhoaBoMonDataSource class.
	/// </summary>
	public class ViewKhoaBoMonDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKhoaBoMon>
	{
		/// <summary>
		/// Initializes a new instance of the ViewKhoaBoMonDataSourceDesigner class.
		/// </summary>
		public ViewKhoaBoMonDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewKhoaBoMonSelectMethod SelectMethod
		{
			get { return ((ViewKhoaBoMonDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewKhoaBoMonDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewKhoaBoMonDataSourceActionList

	/// <summary>
	/// Supports the ViewKhoaBoMonDataSourceDesigner class.
	/// </summary>
	internal class ViewKhoaBoMonDataSourceActionList : DesignerActionList
	{
		private ViewKhoaBoMonDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewKhoaBoMonDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewKhoaBoMonDataSourceActionList(ViewKhoaBoMonDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewKhoaBoMonSelectMethod SelectMethod
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

	#endregion ViewKhoaBoMonDataSourceActionList

	#endregion ViewKhoaBoMonDataSourceDesigner

	#region ViewKhoaBoMonFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoaBoMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoaBoMonFilter : SqlFilter<ViewKhoaBoMonColumn>
	{
	}

	#endregion ViewKhoaBoMonFilter

	#region ViewKhoaBoMonExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoaBoMon"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoaBoMonExpressionBuilder : SqlExpressionBuilder<ViewKhoaBoMonColumn>
	{
	}
	
	#endregion ViewKhoaBoMonExpressionBuilder		
}

