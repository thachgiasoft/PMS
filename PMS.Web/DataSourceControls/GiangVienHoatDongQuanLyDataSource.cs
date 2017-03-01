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
	/// Represents the DataRepository.GiangVienHoatDongQuanLyProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienHoatDongQuanLyDataSourceDesigner))]
	public class GiangVienHoatDongQuanLyDataSource : ProviderDataSource<GiangVienHoatDongQuanLy, GiangVienHoatDongQuanLyKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongQuanLyDataSource class.
		/// </summary>
		public GiangVienHoatDongQuanLyDataSource() : base(new GiangVienHoatDongQuanLyService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienHoatDongQuanLyDataSourceView used by the GiangVienHoatDongQuanLyDataSource.
		/// </summary>
		protected GiangVienHoatDongQuanLyDataSourceView GiangVienHoatDongQuanLyView
		{
			get { return ( View as GiangVienHoatDongQuanLyDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienHoatDongQuanLyDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienHoatDongQuanLySelectMethod SelectMethod
		{
			get
			{
				GiangVienHoatDongQuanLySelectMethod selectMethod = GiangVienHoatDongQuanLySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienHoatDongQuanLySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienHoatDongQuanLyDataSourceView class that is to be
		/// used by the GiangVienHoatDongQuanLyDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienHoatDongQuanLyDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienHoatDongQuanLy, GiangVienHoatDongQuanLyKey> GetNewDataSourceView()
		{
			return new GiangVienHoatDongQuanLyDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienHoatDongQuanLyDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienHoatDongQuanLyDataSourceView : ProviderDataSourceView<GiangVienHoatDongQuanLy, GiangVienHoatDongQuanLyKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongQuanLyDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienHoatDongQuanLyDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienHoatDongQuanLyDataSourceView(GiangVienHoatDongQuanLyDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienHoatDongQuanLyDataSource GiangVienHoatDongQuanLyOwner
		{
			get { return Owner as GiangVienHoatDongQuanLyDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienHoatDongQuanLySelectMethod SelectMethod
		{
			get { return GiangVienHoatDongQuanLyOwner.SelectMethod; }
			set { GiangVienHoatDongQuanLyOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienHoatDongQuanLyService GiangVienHoatDongQuanLyProvider
		{
			get { return Provider as GiangVienHoatDongQuanLyService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienHoatDongQuanLy> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienHoatDongQuanLy> results = null;
			GiangVienHoatDongQuanLy item;
			count = 0;
			
			System.Int32 _id;
			System.Int32? _maHoatDongQuanLy_nullable;
			System.Int32? _maGiangVien_nullable;

			switch ( SelectMethod )
			{
				case GiangVienHoatDongQuanLySelectMethod.Get:
					GiangVienHoatDongQuanLyKey entityKey  = new GiangVienHoatDongQuanLyKey();
					entityKey.Load(values);
					item = GiangVienHoatDongQuanLyProvider.Get(entityKey);
					results = new TList<GiangVienHoatDongQuanLy>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienHoatDongQuanLySelectMethod.GetAll:
                    results = GiangVienHoatDongQuanLyProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienHoatDongQuanLySelectMethod.GetPaged:
					results = GiangVienHoatDongQuanLyProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienHoatDongQuanLySelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienHoatDongQuanLyProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienHoatDongQuanLyProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienHoatDongQuanLySelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = GiangVienHoatDongQuanLyProvider.GetById(_id);
					results = new TList<GiangVienHoatDongQuanLy>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case GiangVienHoatDongQuanLySelectMethod.GetByMaHoatDongQuanLy:
					_maHoatDongQuanLy_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaHoatDongQuanLy"], typeof(System.Int32?));
					results = GiangVienHoatDongQuanLyProvider.GetByMaHoatDongQuanLy(_maHoatDongQuanLy_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case GiangVienHoatDongQuanLySelectMethod.GetByMaGiangVien:
					_maGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					results = GiangVienHoatDongQuanLyProvider.GetByMaGiangVien(_maGiangVien_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
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
			if ( SelectMethod == GiangVienHoatDongQuanLySelectMethod.Get || SelectMethod == GiangVienHoatDongQuanLySelectMethod.GetById )
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
				GiangVienHoatDongQuanLy entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienHoatDongQuanLyProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienHoatDongQuanLy> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienHoatDongQuanLyProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienHoatDongQuanLyDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienHoatDongQuanLyDataSource class.
	/// </summary>
	public class GiangVienHoatDongQuanLyDataSourceDesigner : ProviderDataSourceDesigner<GiangVienHoatDongQuanLy, GiangVienHoatDongQuanLyKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongQuanLyDataSourceDesigner class.
		/// </summary>
		public GiangVienHoatDongQuanLyDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienHoatDongQuanLySelectMethod SelectMethod
		{
			get { return ((GiangVienHoatDongQuanLyDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienHoatDongQuanLyDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienHoatDongQuanLyDataSourceActionList

	/// <summary>
	/// Supports the GiangVienHoatDongQuanLyDataSourceDesigner class.
	/// </summary>
	internal class GiangVienHoatDongQuanLyDataSourceActionList : DesignerActionList
	{
		private GiangVienHoatDongQuanLyDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienHoatDongQuanLyDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienHoatDongQuanLyDataSourceActionList(GiangVienHoatDongQuanLyDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienHoatDongQuanLySelectMethod SelectMethod
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

	#endregion GiangVienHoatDongQuanLyDataSourceActionList
	
	#endregion GiangVienHoatDongQuanLyDataSourceDesigner
	
	#region GiangVienHoatDongQuanLySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienHoatDongQuanLyDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienHoatDongQuanLySelectMethod
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
		/// Represents the GetById method.
		/// </summary>
		GetById,
		/// <summary>
		/// Represents the GetByMaHoatDongQuanLy method.
		/// </summary>
		GetByMaHoatDongQuanLy,
		/// <summary>
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien
	}
	
	#endregion GiangVienHoatDongQuanLySelectMethod

	#region GiangVienHoatDongQuanLyFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienHoatDongQuanLy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienHoatDongQuanLyFilter : SqlFilter<GiangVienHoatDongQuanLyColumn>
	{
	}
	
	#endregion GiangVienHoatDongQuanLyFilter

	#region GiangVienHoatDongQuanLyExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienHoatDongQuanLy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienHoatDongQuanLyExpressionBuilder : SqlExpressionBuilder<GiangVienHoatDongQuanLyColumn>
	{
	}
	
	#endregion GiangVienHoatDongQuanLyExpressionBuilder	

	#region GiangVienHoatDongQuanLyProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienHoatDongQuanLyChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienHoatDongQuanLy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienHoatDongQuanLyProperty : ChildEntityProperty<GiangVienHoatDongQuanLyChildEntityTypes>
	{
	}
	
	#endregion GiangVienHoatDongQuanLyProperty
}

