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
	/// Represents the DataRepository.ViewKcqPhanNhomMonHocActProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKcqPhanNhomMonHocActDataSourceDesigner))]
	public class ViewKcqPhanNhomMonHocActDataSource : ReadOnlyDataSource<ViewKcqPhanNhomMonHocAct>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhanNhomMonHocActDataSource class.
		/// </summary>
		public ViewKcqPhanNhomMonHocActDataSource() : base(new ViewKcqPhanNhomMonHocActService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKcqPhanNhomMonHocActDataSourceView used by the ViewKcqPhanNhomMonHocActDataSource.
		/// </summary>
		protected ViewKcqPhanNhomMonHocActDataSourceView ViewKcqPhanNhomMonHocActView
		{
			get { return ( View as ViewKcqPhanNhomMonHocActDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewKcqPhanNhomMonHocActDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewKcqPhanNhomMonHocActSelectMethod SelectMethod
		{
			get
			{
				ViewKcqPhanNhomMonHocActSelectMethod selectMethod = ViewKcqPhanNhomMonHocActSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewKcqPhanNhomMonHocActSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKcqPhanNhomMonHocActDataSourceView class that is to be
		/// used by the ViewKcqPhanNhomMonHocActDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKcqPhanNhomMonHocActDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKcqPhanNhomMonHocAct, Object> GetNewDataSourceView()
		{
			return new ViewKcqPhanNhomMonHocActDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKcqPhanNhomMonHocActDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKcqPhanNhomMonHocActDataSourceView : ReadOnlyDataSourceView<ViewKcqPhanNhomMonHocAct>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhanNhomMonHocActDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKcqPhanNhomMonHocActDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKcqPhanNhomMonHocActDataSourceView(ViewKcqPhanNhomMonHocActDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKcqPhanNhomMonHocActDataSource ViewKcqPhanNhomMonHocActOwner
		{
			get { return Owner as ViewKcqPhanNhomMonHocActDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewKcqPhanNhomMonHocActSelectMethod SelectMethod
		{
			get { return ViewKcqPhanNhomMonHocActOwner.SelectMethod; }
			set { ViewKcqPhanNhomMonHocActOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKcqPhanNhomMonHocActService ViewKcqPhanNhomMonHocActProvider
		{
			get { return Provider as ViewKcqPhanNhomMonHocActService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewKcqPhanNhomMonHocAct> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewKcqPhanNhomMonHocAct> results = null;
			// ViewKcqPhanNhomMonHocAct item;
			count = 0;
			
			System.String sp3088_NamHoc;
			System.String sp3088_HocKy;

			switch ( SelectMethod )
			{
				case ViewKcqPhanNhomMonHocActSelectMethod.Get:
					results = ViewKcqPhanNhomMonHocActProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewKcqPhanNhomMonHocActSelectMethod.GetPaged:
					results = ViewKcqPhanNhomMonHocActProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewKcqPhanNhomMonHocActSelectMethod.GetAll:
					results = ViewKcqPhanNhomMonHocActProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewKcqPhanNhomMonHocActSelectMethod.Find:
					results = ViewKcqPhanNhomMonHocActProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewKcqPhanNhomMonHocActSelectMethod.GetByNamHocHocKy:
					sp3088_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3088_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewKcqPhanNhomMonHocActProvider.GetByNamHocHocKy(sp3088_NamHoc, sp3088_HocKy, StartIndex, PageSize);
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

	#region ViewKcqPhanNhomMonHocActSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewKcqPhanNhomMonHocActDataSource.SelectMethod property.
	/// </summary>
	public enum ViewKcqPhanNhomMonHocActSelectMethod
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
	
	#endregion ViewKcqPhanNhomMonHocActSelectMethod
	
	#region ViewKcqPhanNhomMonHocActDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKcqPhanNhomMonHocActDataSource class.
	/// </summary>
	public class ViewKcqPhanNhomMonHocActDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKcqPhanNhomMonHocAct>
	{
		/// <summary>
		/// Initializes a new instance of the ViewKcqPhanNhomMonHocActDataSourceDesigner class.
		/// </summary>
		public ViewKcqPhanNhomMonHocActDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewKcqPhanNhomMonHocActSelectMethod SelectMethod
		{
			get { return ((ViewKcqPhanNhomMonHocActDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewKcqPhanNhomMonHocActDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewKcqPhanNhomMonHocActDataSourceActionList

	/// <summary>
	/// Supports the ViewKcqPhanNhomMonHocActDataSourceDesigner class.
	/// </summary>
	internal class ViewKcqPhanNhomMonHocActDataSourceActionList : DesignerActionList
	{
		private ViewKcqPhanNhomMonHocActDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewKcqPhanNhomMonHocActDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewKcqPhanNhomMonHocActDataSourceActionList(ViewKcqPhanNhomMonHocActDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewKcqPhanNhomMonHocActSelectMethod SelectMethod
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

	#endregion ViewKcqPhanNhomMonHocActDataSourceActionList

	#endregion ViewKcqPhanNhomMonHocActDataSourceDesigner

	#region ViewKcqPhanNhomMonHocActFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqPhanNhomMonHocAct"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqPhanNhomMonHocActFilter : SqlFilter<ViewKcqPhanNhomMonHocActColumn>
	{
	}

	#endregion ViewKcqPhanNhomMonHocActFilter

	#region ViewKcqPhanNhomMonHocActExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKcqPhanNhomMonHocAct"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKcqPhanNhomMonHocActExpressionBuilder : SqlExpressionBuilder<ViewKcqPhanNhomMonHocActColumn>
	{
	}
	
	#endregion ViewKcqPhanNhomMonHocActExpressionBuilder		
}

