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
	/// Represents the DataRepository.ViewPhanCongGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewPhanCongGiangDayDataSourceDesigner))]
	public class ViewPhanCongGiangDayDataSource : ReadOnlyDataSource<ViewPhanCongGiangDay>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongGiangDayDataSource class.
		/// </summary>
		public ViewPhanCongGiangDayDataSource() : base(new ViewPhanCongGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewPhanCongGiangDayDataSourceView used by the ViewPhanCongGiangDayDataSource.
		/// </summary>
		protected ViewPhanCongGiangDayDataSourceView ViewPhanCongGiangDayView
		{
			get { return ( View as ViewPhanCongGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewPhanCongGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewPhanCongGiangDaySelectMethod SelectMethod
		{
			get
			{
				ViewPhanCongGiangDaySelectMethod selectMethod = ViewPhanCongGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewPhanCongGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewPhanCongGiangDayDataSourceView class that is to be
		/// used by the ViewPhanCongGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the ViewPhanCongGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewPhanCongGiangDay, Object> GetNewDataSourceView()
		{
			return new ViewPhanCongGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewPhanCongGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewPhanCongGiangDayDataSourceView : ReadOnlyDataSourceView<ViewPhanCongGiangDay>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewPhanCongGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewPhanCongGiangDayDataSourceView(ViewPhanCongGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewPhanCongGiangDayDataSource ViewPhanCongGiangDayOwner
		{
			get { return Owner as ViewPhanCongGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewPhanCongGiangDaySelectMethod SelectMethod
		{
			get { return ViewPhanCongGiangDayOwner.SelectMethod; }
			set { ViewPhanCongGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewPhanCongGiangDayService ViewPhanCongGiangDayProvider
		{
			get { return Provider as ViewPhanCongGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewPhanCongGiangDay> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewPhanCongGiangDay> results = null;
			// ViewPhanCongGiangDay item;
			count = 0;
			
			System.String sp3165_NamHoc;
			System.String sp3165_HocKy;
			System.String sp3165_MaGiangVien;

			switch ( SelectMethod )
			{
				case ViewPhanCongGiangDaySelectMethod.Get:
					results = ViewPhanCongGiangDayProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewPhanCongGiangDaySelectMethod.GetPaged:
					results = ViewPhanCongGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewPhanCongGiangDaySelectMethod.GetAll:
					results = ViewPhanCongGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewPhanCongGiangDaySelectMethod.Find:
					results = ViewPhanCongGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewPhanCongGiangDaySelectMethod.GetByNamHocHocKy:
					sp3165_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3165_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp3165_MaGiangVien = (System.String) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.String));
					results = ViewPhanCongGiangDayProvider.GetByNamHocHocKy(sp3165_NamHoc, sp3165_HocKy, sp3165_MaGiangVien, StartIndex, PageSize);
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

	#region ViewPhanCongGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewPhanCongGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum ViewPhanCongGiangDaySelectMethod
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
	
	#endregion ViewPhanCongGiangDaySelectMethod
	
	#region ViewPhanCongGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewPhanCongGiangDayDataSource class.
	/// </summary>
	public class ViewPhanCongGiangDayDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewPhanCongGiangDay>
	{
		/// <summary>
		/// Initializes a new instance of the ViewPhanCongGiangDayDataSourceDesigner class.
		/// </summary>
		public ViewPhanCongGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewPhanCongGiangDaySelectMethod SelectMethod
		{
			get { return ((ViewPhanCongGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewPhanCongGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewPhanCongGiangDayDataSourceActionList

	/// <summary>
	/// Supports the ViewPhanCongGiangDayDataSourceDesigner class.
	/// </summary>
	internal class ViewPhanCongGiangDayDataSourceActionList : DesignerActionList
	{
		private ViewPhanCongGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewPhanCongGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewPhanCongGiangDayDataSourceActionList(ViewPhanCongGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewPhanCongGiangDaySelectMethod SelectMethod
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

	#endregion ViewPhanCongGiangDayDataSourceActionList

	#endregion ViewPhanCongGiangDayDataSourceDesigner

	#region ViewPhanCongGiangDayFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanCongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanCongGiangDayFilter : SqlFilter<ViewPhanCongGiangDayColumn>
	{
	}

	#endregion ViewPhanCongGiangDayFilter

	#region ViewPhanCongGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanCongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanCongGiangDayExpressionBuilder : SqlExpressionBuilder<ViewPhanCongGiangDayColumn>
	{
	}
	
	#endregion ViewPhanCongGiangDayExpressionBuilder		
}

