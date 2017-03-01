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
	/// Represents the DataRepository.ViewThongKeHoSoChiTietProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewThongKeHoSoChiTietDataSourceDesigner))]
	public class ViewThongKeHoSoChiTietDataSource : ReadOnlyDataSource<ViewThongKeHoSoChiTiet>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoChiTietDataSource class.
		/// </summary>
		public ViewThongKeHoSoChiTietDataSource() : base(new ViewThongKeHoSoChiTietService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewThongKeHoSoChiTietDataSourceView used by the ViewThongKeHoSoChiTietDataSource.
		/// </summary>
		protected ViewThongKeHoSoChiTietDataSourceView ViewThongKeHoSoChiTietView
		{
			get { return ( View as ViewThongKeHoSoChiTietDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewThongKeHoSoChiTietDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewThongKeHoSoChiTietSelectMethod SelectMethod
		{
			get
			{
				ViewThongKeHoSoChiTietSelectMethod selectMethod = ViewThongKeHoSoChiTietSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewThongKeHoSoChiTietSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewThongKeHoSoChiTietDataSourceView class that is to be
		/// used by the ViewThongKeHoSoChiTietDataSource.
		/// </summary>
		/// <returns>An instance of the ViewThongKeHoSoChiTietDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewThongKeHoSoChiTiet, Object> GetNewDataSourceView()
		{
			return new ViewThongKeHoSoChiTietDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewThongKeHoSoChiTietDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewThongKeHoSoChiTietDataSourceView : ReadOnlyDataSourceView<ViewThongKeHoSoChiTiet>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoChiTietDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewThongKeHoSoChiTietDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewThongKeHoSoChiTietDataSourceView(ViewThongKeHoSoChiTietDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewThongKeHoSoChiTietDataSource ViewThongKeHoSoChiTietOwner
		{
			get { return Owner as ViewThongKeHoSoChiTietDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewThongKeHoSoChiTietSelectMethod SelectMethod
		{
			get { return ViewThongKeHoSoChiTietOwner.SelectMethod; }
			set { ViewThongKeHoSoChiTietOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewThongKeHoSoChiTietService ViewThongKeHoSoChiTietProvider
		{
			get { return Provider as ViewThongKeHoSoChiTietService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewThongKeHoSoChiTiet> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewThongKeHoSoChiTiet> results = null;
			// ViewThongKeHoSoChiTiet item;
			count = 0;
			
			System.String sp1111_MaGiangVienQuanLy;

			switch ( SelectMethod )
			{
				case ViewThongKeHoSoChiTietSelectMethod.Get:
					results = ViewThongKeHoSoChiTietProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewThongKeHoSoChiTietSelectMethod.GetPaged:
					results = ViewThongKeHoSoChiTietProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewThongKeHoSoChiTietSelectMethod.GetAll:
					results = ViewThongKeHoSoChiTietProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewThongKeHoSoChiTietSelectMethod.Find:
					results = ViewThongKeHoSoChiTietProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewThongKeHoSoChiTietSelectMethod.GetByMaGiangVienQuanLy:
					sp1111_MaGiangVienQuanLy = (System.String) EntityUtil.ChangeType(values["MaGiangVienQuanLy"], typeof(System.String));
					results = ViewThongKeHoSoChiTietProvider.GetByMaGiangVienQuanLy(sp1111_MaGiangVienQuanLy, StartIndex, PageSize);
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

	#region ViewThongKeHoSoChiTietSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewThongKeHoSoChiTietDataSource.SelectMethod property.
	/// </summary>
	public enum ViewThongKeHoSoChiTietSelectMethod
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
		/// Represents the GetByMaGiangVienQuanLy method.
		/// </summary>
		GetByMaGiangVienQuanLy
	}
	
	#endregion ViewThongKeHoSoChiTietSelectMethod
	
	#region ViewThongKeHoSoChiTietDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewThongKeHoSoChiTietDataSource class.
	/// </summary>
	public class ViewThongKeHoSoChiTietDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewThongKeHoSoChiTiet>
	{
		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoChiTietDataSourceDesigner class.
		/// </summary>
		public ViewThongKeHoSoChiTietDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewThongKeHoSoChiTietSelectMethod SelectMethod
		{
			get { return ((ViewThongKeHoSoChiTietDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewThongKeHoSoChiTietDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewThongKeHoSoChiTietDataSourceActionList

	/// <summary>
	/// Supports the ViewThongKeHoSoChiTietDataSourceDesigner class.
	/// </summary>
	internal class ViewThongKeHoSoChiTietDataSourceActionList : DesignerActionList
	{
		private ViewThongKeHoSoChiTietDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoChiTietDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewThongKeHoSoChiTietDataSourceActionList(ViewThongKeHoSoChiTietDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewThongKeHoSoChiTietSelectMethod SelectMethod
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

	#endregion ViewThongKeHoSoChiTietDataSourceActionList

	#endregion ViewThongKeHoSoChiTietDataSourceDesigner

	#region ViewThongKeHoSoChiTietFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongKeHoSoChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongKeHoSoChiTietFilter : SqlFilter<ViewThongKeHoSoChiTietColumn>
	{
	}

	#endregion ViewThongKeHoSoChiTietFilter

	#region ViewThongKeHoSoChiTietExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongKeHoSoChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongKeHoSoChiTietExpressionBuilder : SqlExpressionBuilder<ViewThongKeHoSoChiTietColumn>
	{
	}
	
	#endregion ViewThongKeHoSoChiTietExpressionBuilder		
}

