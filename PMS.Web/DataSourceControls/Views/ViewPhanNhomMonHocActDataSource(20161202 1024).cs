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
	/// Represents the DataRepository.ViewPhanNhomMonHocActProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewPhanNhomMonHocActDataSourceDesigner))]
	public class ViewPhanNhomMonHocActDataSource : ReadOnlyDataSource<ViewPhanNhomMonHocAct>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomMonHocActDataSource class.
		/// </summary>
		public ViewPhanNhomMonHocActDataSource() : base(new ViewPhanNhomMonHocActService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewPhanNhomMonHocActDataSourceView used by the ViewPhanNhomMonHocActDataSource.
		/// </summary>
		protected ViewPhanNhomMonHocActDataSourceView ViewPhanNhomMonHocActView
		{
			get { return ( View as ViewPhanNhomMonHocActDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewPhanNhomMonHocActDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewPhanNhomMonHocActSelectMethod SelectMethod
		{
			get
			{
				ViewPhanNhomMonHocActSelectMethod selectMethod = ViewPhanNhomMonHocActSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewPhanNhomMonHocActSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewPhanNhomMonHocActDataSourceView class that is to be
		/// used by the ViewPhanNhomMonHocActDataSource.
		/// </summary>
		/// <returns>An instance of the ViewPhanNhomMonHocActDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewPhanNhomMonHocAct, Object> GetNewDataSourceView()
		{
			return new ViewPhanNhomMonHocActDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewPhanNhomMonHocActDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewPhanNhomMonHocActDataSourceView : ReadOnlyDataSourceView<ViewPhanNhomMonHocAct>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomMonHocActDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewPhanNhomMonHocActDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewPhanNhomMonHocActDataSourceView(ViewPhanNhomMonHocActDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewPhanNhomMonHocActDataSource ViewPhanNhomMonHocActOwner
		{
			get { return Owner as ViewPhanNhomMonHocActDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewPhanNhomMonHocActSelectMethod SelectMethod
		{
			get { return ViewPhanNhomMonHocActOwner.SelectMethod; }
			set { ViewPhanNhomMonHocActOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewPhanNhomMonHocActService ViewPhanNhomMonHocActProvider
		{
			get { return Provider as ViewPhanNhomMonHocActService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewPhanNhomMonHocAct> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewPhanNhomMonHocAct> results = null;
			// ViewPhanNhomMonHocAct item;
			count = 0;
			
			System.String sp3168_NamHoc;
			System.String sp3168_HocKy;

			switch ( SelectMethod )
			{
				case ViewPhanNhomMonHocActSelectMethod.Get:
					results = ViewPhanNhomMonHocActProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewPhanNhomMonHocActSelectMethod.GetPaged:
					results = ViewPhanNhomMonHocActProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewPhanNhomMonHocActSelectMethod.GetAll:
					results = ViewPhanNhomMonHocActProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewPhanNhomMonHocActSelectMethod.Find:
					results = ViewPhanNhomMonHocActProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewPhanNhomMonHocActSelectMethod.GetByNamHocHocKy:
					sp3168_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3168_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewPhanNhomMonHocActProvider.GetByNamHocHocKy(sp3168_NamHoc, sp3168_HocKy, StartIndex, PageSize);
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

	#region ViewPhanNhomMonHocActSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewPhanNhomMonHocActDataSource.SelectMethod property.
	/// </summary>
	public enum ViewPhanNhomMonHocActSelectMethod
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
	
	#endregion ViewPhanNhomMonHocActSelectMethod
	
	#region ViewPhanNhomMonHocActDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewPhanNhomMonHocActDataSource class.
	/// </summary>
	public class ViewPhanNhomMonHocActDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewPhanNhomMonHocAct>
	{
		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomMonHocActDataSourceDesigner class.
		/// </summary>
		public ViewPhanNhomMonHocActDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewPhanNhomMonHocActSelectMethod SelectMethod
		{
			get { return ((ViewPhanNhomMonHocActDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewPhanNhomMonHocActDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewPhanNhomMonHocActDataSourceActionList

	/// <summary>
	/// Supports the ViewPhanNhomMonHocActDataSourceDesigner class.
	/// </summary>
	internal class ViewPhanNhomMonHocActDataSourceActionList : DesignerActionList
	{
		private ViewPhanNhomMonHocActDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewPhanNhomMonHocActDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewPhanNhomMonHocActDataSourceActionList(ViewPhanNhomMonHocActDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewPhanNhomMonHocActSelectMethod SelectMethod
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

	#endregion ViewPhanNhomMonHocActDataSourceActionList

	#endregion ViewPhanNhomMonHocActDataSourceDesigner

	#region ViewPhanNhomMonHocActFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanNhomMonHocAct"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanNhomMonHocActFilter : SqlFilter<ViewPhanNhomMonHocActColumn>
	{
	}

	#endregion ViewPhanNhomMonHocActFilter

	#region ViewPhanNhomMonHocActExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanNhomMonHocAct"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanNhomMonHocActExpressionBuilder : SqlExpressionBuilder<ViewPhanNhomMonHocActColumn>
	{
	}
	
	#endregion ViewPhanNhomMonHocActExpressionBuilder		
}

