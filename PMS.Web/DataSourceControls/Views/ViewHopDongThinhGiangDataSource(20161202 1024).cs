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
	/// Represents the DataRepository.ViewHopDongThinhGiangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewHopDongThinhGiangDataSourceDesigner))]
	public class ViewHopDongThinhGiangDataSource : ReadOnlyDataSource<ViewHopDongThinhGiang>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHopDongThinhGiangDataSource class.
		/// </summary>
		public ViewHopDongThinhGiangDataSource() : base(new ViewHopDongThinhGiangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewHopDongThinhGiangDataSourceView used by the ViewHopDongThinhGiangDataSource.
		/// </summary>
		protected ViewHopDongThinhGiangDataSourceView ViewHopDongThinhGiangView
		{
			get { return ( View as ViewHopDongThinhGiangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewHopDongThinhGiangDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewHopDongThinhGiangSelectMethod SelectMethod
		{
			get
			{
				ViewHopDongThinhGiangSelectMethod selectMethod = ViewHopDongThinhGiangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewHopDongThinhGiangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewHopDongThinhGiangDataSourceView class that is to be
		/// used by the ViewHopDongThinhGiangDataSource.
		/// </summary>
		/// <returns>An instance of the ViewHopDongThinhGiangDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewHopDongThinhGiang, Object> GetNewDataSourceView()
		{
			return new ViewHopDongThinhGiangDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewHopDongThinhGiangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewHopDongThinhGiangDataSourceView : ReadOnlyDataSourceView<ViewHopDongThinhGiang>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHopDongThinhGiangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewHopDongThinhGiangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewHopDongThinhGiangDataSourceView(ViewHopDongThinhGiangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewHopDongThinhGiangDataSource ViewHopDongThinhGiangOwner
		{
			get { return Owner as ViewHopDongThinhGiangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewHopDongThinhGiangSelectMethod SelectMethod
		{
			get { return ViewHopDongThinhGiangOwner.SelectMethod; }
			set { ViewHopDongThinhGiangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewHopDongThinhGiangService ViewHopDongThinhGiangProvider
		{
			get { return Provider as ViewHopDongThinhGiangService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewHopDongThinhGiang> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewHopDongThinhGiang> results = null;
			// ViewHopDongThinhGiang item;
			count = 0;
			
			System.String sp3078_NamHoc;
			System.String sp3078_HocKy;

			switch ( SelectMethod )
			{
				case ViewHopDongThinhGiangSelectMethod.Get:
					results = ViewHopDongThinhGiangProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewHopDongThinhGiangSelectMethod.GetPaged:
					results = ViewHopDongThinhGiangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewHopDongThinhGiangSelectMethod.GetAll:
					results = ViewHopDongThinhGiangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewHopDongThinhGiangSelectMethod.Find:
					results = ViewHopDongThinhGiangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewHopDongThinhGiangSelectMethod.GetByNamHocHocKy:
					sp3078_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3078_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewHopDongThinhGiangProvider.GetByNamHocHocKy(sp3078_NamHoc, sp3078_HocKy, StartIndex, PageSize);
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

	#region ViewHopDongThinhGiangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewHopDongThinhGiangDataSource.SelectMethod property.
	/// </summary>
	public enum ViewHopDongThinhGiangSelectMethod
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
	
	#endregion ViewHopDongThinhGiangSelectMethod
	
	#region ViewHopDongThinhGiangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewHopDongThinhGiangDataSource class.
	/// </summary>
	public class ViewHopDongThinhGiangDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewHopDongThinhGiang>
	{
		/// <summary>
		/// Initializes a new instance of the ViewHopDongThinhGiangDataSourceDesigner class.
		/// </summary>
		public ViewHopDongThinhGiangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewHopDongThinhGiangSelectMethod SelectMethod
		{
			get { return ((ViewHopDongThinhGiangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewHopDongThinhGiangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewHopDongThinhGiangDataSourceActionList

	/// <summary>
	/// Supports the ViewHopDongThinhGiangDataSourceDesigner class.
	/// </summary>
	internal class ViewHopDongThinhGiangDataSourceActionList : DesignerActionList
	{
		private ViewHopDongThinhGiangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewHopDongThinhGiangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewHopDongThinhGiangDataSourceActionList(ViewHopDongThinhGiangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewHopDongThinhGiangSelectMethod SelectMethod
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

	#endregion ViewHopDongThinhGiangDataSourceActionList

	#endregion ViewHopDongThinhGiangDataSourceDesigner

	#region ViewHopDongThinhGiangFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHopDongThinhGiangFilter : SqlFilter<ViewHopDongThinhGiangColumn>
	{
	}

	#endregion ViewHopDongThinhGiangFilter

	#region ViewHopDongThinhGiangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHopDongThinhGiangExpressionBuilder : SqlExpressionBuilder<ViewHopDongThinhGiangColumn>
	{
	}
	
	#endregion ViewHopDongThinhGiangExpressionBuilder		
}

