#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.GiangVienHoatDongNgoaiGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienHoatDongNgoaiGiangDayDataSourceDesigner))]
	public class GiangVienHoatDongNgoaiGiangDayDataSource : ProviderDataSource<GiangVienHoatDongNgoaiGiangDay, GiangVienHoatDongNgoaiGiangDayKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongNgoaiGiangDayDataSource class.
		/// </summary>
		public GiangVienHoatDongNgoaiGiangDayDataSource() : base(new GiangVienHoatDongNgoaiGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienHoatDongNgoaiGiangDayDataSourceView used by the GiangVienHoatDongNgoaiGiangDayDataSource.
		/// </summary>
		protected GiangVienHoatDongNgoaiGiangDayDataSourceView GiangVienHoatDongNgoaiGiangDayView
		{
			get { return ( View as GiangVienHoatDongNgoaiGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienHoatDongNgoaiGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienHoatDongNgoaiGiangDaySelectMethod SelectMethod
		{
			get
			{
				GiangVienHoatDongNgoaiGiangDaySelectMethod selectMethod = GiangVienHoatDongNgoaiGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienHoatDongNgoaiGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienHoatDongNgoaiGiangDayDataSourceView class that is to be
		/// used by the GiangVienHoatDongNgoaiGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienHoatDongNgoaiGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienHoatDongNgoaiGiangDay, GiangVienHoatDongNgoaiGiangDayKey> GetNewDataSourceView()
		{
			return new GiangVienHoatDongNgoaiGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienHoatDongNgoaiGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienHoatDongNgoaiGiangDayDataSourceView : ProviderDataSourceView<GiangVienHoatDongNgoaiGiangDay, GiangVienHoatDongNgoaiGiangDayKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongNgoaiGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienHoatDongNgoaiGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienHoatDongNgoaiGiangDayDataSourceView(GiangVienHoatDongNgoaiGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienHoatDongNgoaiGiangDayDataSource GiangVienHoatDongNgoaiGiangDayOwner
		{
			get { return Owner as GiangVienHoatDongNgoaiGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienHoatDongNgoaiGiangDaySelectMethod SelectMethod
		{
			get { return GiangVienHoatDongNgoaiGiangDayOwner.SelectMethod; }
			set { GiangVienHoatDongNgoaiGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienHoatDongNgoaiGiangDayService GiangVienHoatDongNgoaiGiangDayProvider
		{
			get { return Provider as GiangVienHoatDongNgoaiGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienHoatDongNgoaiGiangDay> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienHoatDongNgoaiGiangDay> results = null;
			GiangVienHoatDongNgoaiGiangDay item;
			count = 0;
			
			System.Int32 _maQuanLy;
			System.Int32? _maGiangVien_nullable;
			System.Int32? _maHoatDong_nullable;
			System.String sp155_NamHoc;

			switch ( SelectMethod )
			{
				case GiangVienHoatDongNgoaiGiangDaySelectMethod.Get:
					GiangVienHoatDongNgoaiGiangDayKey entityKey  = new GiangVienHoatDongNgoaiGiangDayKey();
					entityKey.Load(values);
					item = GiangVienHoatDongNgoaiGiangDayProvider.Get(entityKey);
					results = new TList<GiangVienHoatDongNgoaiGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienHoatDongNgoaiGiangDaySelectMethod.GetAll:
                    results = GiangVienHoatDongNgoaiGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienHoatDongNgoaiGiangDaySelectMethod.GetPaged:
					results = GiangVienHoatDongNgoaiGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienHoatDongNgoaiGiangDaySelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienHoatDongNgoaiGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienHoatDongNgoaiGiangDayProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienHoatDongNgoaiGiangDaySelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.Int32)) : (int)0;
					item = GiangVienHoatDongNgoaiGiangDayProvider.GetByMaQuanLy(_maQuanLy);
					results = new TList<GiangVienHoatDongNgoaiGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case GiangVienHoatDongNgoaiGiangDaySelectMethod.GetByMaGiangVien:
					_maGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					results = GiangVienHoatDongNgoaiGiangDayProvider.GetByMaGiangVien(_maGiangVien_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case GiangVienHoatDongNgoaiGiangDaySelectMethod.GetByMaHoatDong:
					_maHoatDong_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaHoatDong"], typeof(System.Int32?));
					results = GiangVienHoatDongNgoaiGiangDayProvider.GetByMaHoatDong(_maHoatDong_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				case GiangVienHoatDongNgoaiGiangDaySelectMethod.GetByNamHoc:
					sp155_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					results = GiangVienHoatDongNgoaiGiangDayProvider.GetByNamHoc(sp155_NamHoc, StartIndex, PageSize);
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
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == GiangVienHoatDongNgoaiGiangDaySelectMethod.Get || SelectMethod == GiangVienHoatDongNgoaiGiangDaySelectMethod.GetByMaQuanLy )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				GiangVienHoatDongNgoaiGiangDay entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienHoatDongNgoaiGiangDayProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<GiangVienHoatDongNgoaiGiangDay> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienHoatDongNgoaiGiangDayProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienHoatDongNgoaiGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienHoatDongNgoaiGiangDayDataSource class.
	/// </summary>
	public class GiangVienHoatDongNgoaiGiangDayDataSourceDesigner : ProviderDataSourceDesigner<GiangVienHoatDongNgoaiGiangDay, GiangVienHoatDongNgoaiGiangDayKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongNgoaiGiangDayDataSourceDesigner class.
		/// </summary>
		public GiangVienHoatDongNgoaiGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienHoatDongNgoaiGiangDaySelectMethod SelectMethod
		{
			get { return ((GiangVienHoatDongNgoaiGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienHoatDongNgoaiGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienHoatDongNgoaiGiangDayDataSourceActionList

	/// <summary>
	/// Supports the GiangVienHoatDongNgoaiGiangDayDataSourceDesigner class.
	/// </summary>
	internal class GiangVienHoatDongNgoaiGiangDayDataSourceActionList : DesignerActionList
	{
		private GiangVienHoatDongNgoaiGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongNgoaiGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienHoatDongNgoaiGiangDayDataSourceActionList(GiangVienHoatDongNgoaiGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienHoatDongNgoaiGiangDaySelectMethod SelectMethod
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

	#endregion GiangVienHoatDongNgoaiGiangDayDataSourceActionList
	
	#endregion GiangVienHoatDongNgoaiGiangDayDataSourceDesigner
	
	#region GiangVienHoatDongNgoaiGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienHoatDongNgoaiGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienHoatDongNgoaiGiangDaySelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByMaQuanLy method.
		/// </summary>
		GetByMaQuanLy,
		/// <summary>
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien,
		/// <summary>
		/// Represents the GetByMaHoatDong method.
		/// </summary>
		GetByMaHoatDong,
		/// <summary>
		/// Represents the GetByNamHoc method.
		/// </summary>
		GetByNamHoc
	}
	
	#endregion GiangVienHoatDongNgoaiGiangDaySelectMethod

	#region GiangVienHoatDongNgoaiGiangDayFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienHoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienHoatDongNgoaiGiangDayFilter : SqlFilter<GiangVienHoatDongNgoaiGiangDayColumn>
	{
	}
	
	#endregion GiangVienHoatDongNgoaiGiangDayFilter

	#region GiangVienHoatDongNgoaiGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienHoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienHoatDongNgoaiGiangDayExpressionBuilder : SqlExpressionBuilder<GiangVienHoatDongNgoaiGiangDayColumn>
	{
	}
	
	#endregion GiangVienHoatDongNgoaiGiangDayExpressionBuilder	

	#region GiangVienHoatDongNgoaiGiangDayProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienHoatDongNgoaiGiangDayChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienHoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienHoatDongNgoaiGiangDayProperty : ChildEntityProperty<GiangVienHoatDongNgoaiGiangDayChildEntityTypes>
	{
	}
	
	#endregion GiangVienHoatDongNgoaiGiangDayProperty
}

