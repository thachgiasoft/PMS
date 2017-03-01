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
	/// Represents the DataRepository.ViewGiangVienNckhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewGiangVienNckhDataSourceDesigner))]
	public class ViewGiangVienNckhDataSource : ReadOnlyDataSource<ViewGiangVienNckh>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienNckhDataSource class.
		/// </summary>
		public ViewGiangVienNckhDataSource() : base(new ViewGiangVienNckhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewGiangVienNckhDataSourceView used by the ViewGiangVienNckhDataSource.
		/// </summary>
		protected ViewGiangVienNckhDataSourceView ViewGiangVienNckhView
		{
			get { return ( View as ViewGiangVienNckhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewGiangVienNckhDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewGiangVienNckhSelectMethod SelectMethod
		{
			get
			{
				ViewGiangVienNckhSelectMethod selectMethod = ViewGiangVienNckhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewGiangVienNckhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewGiangVienNckhDataSourceView class that is to be
		/// used by the ViewGiangVienNckhDataSource.
		/// </summary>
		/// <returns>An instance of the ViewGiangVienNckhDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewGiangVienNckh, Object> GetNewDataSourceView()
		{
			return new ViewGiangVienNckhDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewGiangVienNckhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewGiangVienNckhDataSourceView : ReadOnlyDataSourceView<ViewGiangVienNckh>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienNckhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewGiangVienNckhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewGiangVienNckhDataSourceView(ViewGiangVienNckhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewGiangVienNckhDataSource ViewGiangVienNckhOwner
		{
			get { return Owner as ViewGiangVienNckhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewGiangVienNckhSelectMethod SelectMethod
		{
			get { return ViewGiangVienNckhOwner.SelectMethod; }
			set { ViewGiangVienNckhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewGiangVienNckhService ViewGiangVienNckhProvider
		{
			get { return Provider as ViewGiangVienNckhService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewGiangVienNckh> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewGiangVienNckh> results = null;
			// ViewGiangVienNckh item;
			count = 0;
			
			System.String sp969_NamHoc;
			System.String sp969_HocKy;
			System.String sp970_NamHoc;
			System.String sp970_HocKy;
			System.String sp970_MaDonVi;
			System.String sp968_NamHoc;

			switch ( SelectMethod )
			{
				case ViewGiangVienNckhSelectMethod.Get:
					results = ViewGiangVienNckhProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewGiangVienNckhSelectMethod.GetPaged:
					results = ViewGiangVienNckhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewGiangVienNckhSelectMethod.GetAll:
					results = ViewGiangVienNckhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewGiangVienNckhSelectMethod.Find:
					results = ViewGiangVienNckhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewGiangVienNckhSelectMethod.GetByNamHocHocKy:
					sp969_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp969_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewGiangVienNckhProvider.GetByNamHocHocKy(sp969_NamHoc, sp969_HocKy, StartIndex, PageSize);
					break;
				case ViewGiangVienNckhSelectMethod.GetByNamHocHocKyMaDonVi:
					sp970_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp970_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp970_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = ViewGiangVienNckhProvider.GetByNamHocHocKyMaDonVi(sp970_NamHoc, sp970_HocKy, sp970_MaDonVi, StartIndex, PageSize);
					break;
				case ViewGiangVienNckhSelectMethod.GetByNamHoc:
					sp968_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					results = ViewGiangVienNckhProvider.GetByNamHoc(sp968_NamHoc, StartIndex, PageSize);
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

	#region ViewGiangVienNckhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewGiangVienNckhDataSource.SelectMethod property.
	/// </summary>
	public enum ViewGiangVienNckhSelectMethod
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
		GetByNamHocHocKy,
		/// <summary>
		/// Represents the GetByNamHocHocKyMaDonVi method.
		/// </summary>
		GetByNamHocHocKyMaDonVi,
		/// <summary>
		/// Represents the GetByNamHoc method.
		/// </summary>
		GetByNamHoc
	}
	
	#endregion ViewGiangVienNckhSelectMethod
	
	#region ViewGiangVienNckhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewGiangVienNckhDataSource class.
	/// </summary>
	public class ViewGiangVienNckhDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewGiangVienNckh>
	{
		/// <summary>
		/// Initializes a new instance of the ViewGiangVienNckhDataSourceDesigner class.
		/// </summary>
		public ViewGiangVienNckhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewGiangVienNckhSelectMethod SelectMethod
		{
			get { return ((ViewGiangVienNckhDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewGiangVienNckhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewGiangVienNckhDataSourceActionList

	/// <summary>
	/// Supports the ViewGiangVienNckhDataSourceDesigner class.
	/// </summary>
	internal class ViewGiangVienNckhDataSourceActionList : DesignerActionList
	{
		private ViewGiangVienNckhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienNckhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewGiangVienNckhDataSourceActionList(ViewGiangVienNckhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewGiangVienNckhSelectMethod SelectMethod
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

	#endregion ViewGiangVienNckhDataSourceActionList

	#endregion ViewGiangVienNckhDataSourceDesigner

	#region ViewGiangVienNckhFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienNckh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienNckhFilter : SqlFilter<ViewGiangVienNckhColumn>
	{
	}

	#endregion ViewGiangVienNckhFilter

	#region ViewGiangVienNckhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienNckh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienNckhExpressionBuilder : SqlExpressionBuilder<ViewGiangVienNckhColumn>
	{
	}
	
	#endregion ViewGiangVienNckhExpressionBuilder		
}

