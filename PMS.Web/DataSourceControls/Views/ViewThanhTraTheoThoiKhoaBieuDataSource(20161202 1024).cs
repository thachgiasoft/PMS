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
	/// Represents the DataRepository.ViewThanhTraTheoThoiKhoaBieuProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewThanhTraTheoThoiKhoaBieuDataSourceDesigner))]
	public class ViewThanhTraTheoThoiKhoaBieuDataSource : ReadOnlyDataSource<ViewThanhTraTheoThoiKhoaBieu>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraTheoThoiKhoaBieuDataSource class.
		/// </summary>
		public ViewThanhTraTheoThoiKhoaBieuDataSource() : base(new ViewThanhTraTheoThoiKhoaBieuService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewThanhTraTheoThoiKhoaBieuDataSourceView used by the ViewThanhTraTheoThoiKhoaBieuDataSource.
		/// </summary>
		protected ViewThanhTraTheoThoiKhoaBieuDataSourceView ViewThanhTraTheoThoiKhoaBieuView
		{
			get { return ( View as ViewThanhTraTheoThoiKhoaBieuDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewThanhTraTheoThoiKhoaBieuDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewThanhTraTheoThoiKhoaBieuSelectMethod SelectMethod
		{
			get
			{
				ViewThanhTraTheoThoiKhoaBieuSelectMethod selectMethod = ViewThanhTraTheoThoiKhoaBieuSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewThanhTraTheoThoiKhoaBieuSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewThanhTraTheoThoiKhoaBieuDataSourceView class that is to be
		/// used by the ViewThanhTraTheoThoiKhoaBieuDataSource.
		/// </summary>
		/// <returns>An instance of the ViewThanhTraTheoThoiKhoaBieuDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewThanhTraTheoThoiKhoaBieu, Object> GetNewDataSourceView()
		{
			return new ViewThanhTraTheoThoiKhoaBieuDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewThanhTraTheoThoiKhoaBieuDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewThanhTraTheoThoiKhoaBieuDataSourceView : ReadOnlyDataSourceView<ViewThanhTraTheoThoiKhoaBieu>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraTheoThoiKhoaBieuDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewThanhTraTheoThoiKhoaBieuDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewThanhTraTheoThoiKhoaBieuDataSourceView(ViewThanhTraTheoThoiKhoaBieuDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewThanhTraTheoThoiKhoaBieuDataSource ViewThanhTraTheoThoiKhoaBieuOwner
		{
			get { return Owner as ViewThanhTraTheoThoiKhoaBieuDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewThanhTraTheoThoiKhoaBieuSelectMethod SelectMethod
		{
			get { return ViewThanhTraTheoThoiKhoaBieuOwner.SelectMethod; }
			set { ViewThanhTraTheoThoiKhoaBieuOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewThanhTraTheoThoiKhoaBieuService ViewThanhTraTheoThoiKhoaBieuProvider
		{
			get { return Provider as ViewThanhTraTheoThoiKhoaBieuService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewThanhTraTheoThoiKhoaBieu> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewThanhTraTheoThoiKhoaBieu> results = null;
			// ViewThanhTraTheoThoiKhoaBieu item;
			count = 0;
			
			System.String sp3197_TuNgay;
			System.String sp3197_DenNgay;
			System.String sp3197_ToaNha;
			System.String sp3190_TuNgay;
			System.String sp3190_DenNgay;
			System.String sp3189_MaCanBoGiangDay;
			System.String sp3189_TuNgay;
			System.String sp3189_DenNgay;
			System.String sp3195_TuNgay;
			System.String sp3195_DenNgay;
			System.String sp3191_TuNgay;
			System.String sp3191_DenNgay;
			System.String sp3191_ToaNha;

			switch ( SelectMethod )
			{
				case ViewThanhTraTheoThoiKhoaBieuSelectMethod.Get:
					results = ViewThanhTraTheoThoiKhoaBieuProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewThanhTraTheoThoiKhoaBieuSelectMethod.GetPaged:
					results = ViewThanhTraTheoThoiKhoaBieuProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewThanhTraTheoThoiKhoaBieuSelectMethod.GetAll:
					results = ViewThanhTraTheoThoiKhoaBieuProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewThanhTraTheoThoiKhoaBieuSelectMethod.Find:
					results = ViewThanhTraTheoThoiKhoaBieuProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewThanhTraTheoThoiKhoaBieuSelectMethod.ThongKeTheoNgayToaNha:
					sp3197_TuNgay = (System.String) EntityUtil.ChangeType(values["TuNgay"], typeof(System.String));
					sp3197_DenNgay = (System.String) EntityUtil.ChangeType(values["DenNgay"], typeof(System.String));
					sp3197_ToaNha = (System.String) EntityUtil.ChangeType(values["ToaNha"], typeof(System.String));
					results = ViewThanhTraTheoThoiKhoaBieuProvider.ThongKeTheoNgayToaNha(sp3197_TuNgay, sp3197_DenNgay, sp3197_ToaNha, StartIndex, PageSize);
					break;
				case ViewThanhTraTheoThoiKhoaBieuSelectMethod.GetByNgay:
					sp3190_TuNgay = (System.String) EntityUtil.ChangeType(values["TuNgay"], typeof(System.String));
					sp3190_DenNgay = (System.String) EntityUtil.ChangeType(values["DenNgay"], typeof(System.String));
					results = ViewThanhTraTheoThoiKhoaBieuProvider.GetByNgay(sp3190_TuNgay, sp3190_DenNgay, StartIndex, PageSize);
					break;
				case ViewThanhTraTheoThoiKhoaBieuSelectMethod.GetByMaGiangVien:
					sp3189_MaCanBoGiangDay = (System.String) EntityUtil.ChangeType(values["MaCanBoGiangDay"], typeof(System.String));
					sp3189_TuNgay = (System.String) EntityUtil.ChangeType(values["TuNgay"], typeof(System.String));
					sp3189_DenNgay = (System.String) EntityUtil.ChangeType(values["DenNgay"], typeof(System.String));
					results = ViewThanhTraTheoThoiKhoaBieuProvider.GetByMaGiangVien(sp3189_MaCanBoGiangDay, sp3189_TuNgay, sp3189_DenNgay, StartIndex, PageSize);
					break;
				case ViewThanhTraTheoThoiKhoaBieuSelectMethod.ThongKeTheoNgay:
					sp3195_TuNgay = (System.String) EntityUtil.ChangeType(values["TuNgay"], typeof(System.String));
					sp3195_DenNgay = (System.String) EntityUtil.ChangeType(values["DenNgay"], typeof(System.String));
					results = ViewThanhTraTheoThoiKhoaBieuProvider.ThongKeTheoNgay(sp3195_TuNgay, sp3195_DenNgay, StartIndex, PageSize);
					break;
				case ViewThanhTraTheoThoiKhoaBieuSelectMethod.GetByNgayCoSoToaNha:
					sp3191_TuNgay = (System.String) EntityUtil.ChangeType(values["TuNgay"], typeof(System.String));
					sp3191_DenNgay = (System.String) EntityUtil.ChangeType(values["DenNgay"], typeof(System.String));
					sp3191_ToaNha = (System.String) EntityUtil.ChangeType(values["ToaNha"], typeof(System.String));
					results = ViewThanhTraTheoThoiKhoaBieuProvider.GetByNgayCoSoToaNha(sp3191_TuNgay, sp3191_DenNgay, sp3191_ToaNha, StartIndex, PageSize);
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

	#region ViewThanhTraTheoThoiKhoaBieuSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewThanhTraTheoThoiKhoaBieuDataSource.SelectMethod property.
	/// </summary>
	public enum ViewThanhTraTheoThoiKhoaBieuSelectMethod
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
		/// Represents the ThongKeTheoNgayToaNha method.
		/// </summary>
		ThongKeTheoNgayToaNha,
		/// <summary>
		/// Represents the GetByNgay method.
		/// </summary>
		GetByNgay,
		/// <summary>
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien,
		/// <summary>
		/// Represents the ThongKeTheoNgay method.
		/// </summary>
		ThongKeTheoNgay,
		/// <summary>
		/// Represents the GetByNgayCoSoToaNha method.
		/// </summary>
		GetByNgayCoSoToaNha
	}
	
	#endregion ViewThanhTraTheoThoiKhoaBieuSelectMethod
	
	#region ViewThanhTraTheoThoiKhoaBieuDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewThanhTraTheoThoiKhoaBieuDataSource class.
	/// </summary>
	public class ViewThanhTraTheoThoiKhoaBieuDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewThanhTraTheoThoiKhoaBieu>
	{
		/// <summary>
		/// Initializes a new instance of the ViewThanhTraTheoThoiKhoaBieuDataSourceDesigner class.
		/// </summary>
		public ViewThanhTraTheoThoiKhoaBieuDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewThanhTraTheoThoiKhoaBieuSelectMethod SelectMethod
		{
			get { return ((ViewThanhTraTheoThoiKhoaBieuDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewThanhTraTheoThoiKhoaBieuDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewThanhTraTheoThoiKhoaBieuDataSourceActionList

	/// <summary>
	/// Supports the ViewThanhTraTheoThoiKhoaBieuDataSourceDesigner class.
	/// </summary>
	internal class ViewThanhTraTheoThoiKhoaBieuDataSourceActionList : DesignerActionList
	{
		private ViewThanhTraTheoThoiKhoaBieuDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewThanhTraTheoThoiKhoaBieuDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewThanhTraTheoThoiKhoaBieuDataSourceActionList(ViewThanhTraTheoThoiKhoaBieuDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewThanhTraTheoThoiKhoaBieuSelectMethod SelectMethod
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

	#endregion ViewThanhTraTheoThoiKhoaBieuDataSourceActionList

	#endregion ViewThanhTraTheoThoiKhoaBieuDataSourceDesigner

	#region ViewThanhTraTheoThoiKhoaBieuFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraTheoThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhTraTheoThoiKhoaBieuFilter : SqlFilter<ViewThanhTraTheoThoiKhoaBieuColumn>
	{
	}

	#endregion ViewThanhTraTheoThoiKhoaBieuFilter

	#region ViewThanhTraTheoThoiKhoaBieuExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhTraTheoThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhTraTheoThoiKhoaBieuExpressionBuilder : SqlExpressionBuilder<ViewThanhTraTheoThoiKhoaBieuColumn>
	{
	}
	
	#endregion ViewThanhTraTheoThoiKhoaBieuExpressionBuilder		
}

