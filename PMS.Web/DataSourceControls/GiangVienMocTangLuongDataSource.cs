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
	/// Represents the DataRepository.GiangVienMocTangLuongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienMocTangLuongDataSourceDesigner))]
	public class GiangVienMocTangLuongDataSource : ProviderDataSource<GiangVienMocTangLuong, GiangVienMocTangLuongKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienMocTangLuongDataSource class.
		/// </summary>
		public GiangVienMocTangLuongDataSource() : base(new GiangVienMocTangLuongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienMocTangLuongDataSourceView used by the GiangVienMocTangLuongDataSource.
		/// </summary>
		protected GiangVienMocTangLuongDataSourceView GiangVienMocTangLuongView
		{
			get { return ( View as GiangVienMocTangLuongDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienMocTangLuongDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienMocTangLuongSelectMethod SelectMethod
		{
			get
			{
				GiangVienMocTangLuongSelectMethod selectMethod = GiangVienMocTangLuongSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienMocTangLuongSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienMocTangLuongDataSourceView class that is to be
		/// used by the GiangVienMocTangLuongDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienMocTangLuongDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienMocTangLuong, GiangVienMocTangLuongKey> GetNewDataSourceView()
		{
			return new GiangVienMocTangLuongDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienMocTangLuongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienMocTangLuongDataSourceView : ProviderDataSourceView<GiangVienMocTangLuong, GiangVienMocTangLuongKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienMocTangLuongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienMocTangLuongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienMocTangLuongDataSourceView(GiangVienMocTangLuongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienMocTangLuongDataSource GiangVienMocTangLuongOwner
		{
			get { return Owner as GiangVienMocTangLuongDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienMocTangLuongSelectMethod SelectMethod
		{
			get { return GiangVienMocTangLuongOwner.SelectMethod; }
			set { GiangVienMocTangLuongOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienMocTangLuongService GiangVienMocTangLuongProvider
		{
			get { return Provider as GiangVienMocTangLuongService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienMocTangLuong> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienMocTangLuong> results = null;
			GiangVienMocTangLuong item;
			count = 0;
			
			System.Int32 _id;
			System.Int32? _maGiangVien_nullable;

			switch ( SelectMethod )
			{
				case GiangVienMocTangLuongSelectMethod.Get:
					GiangVienMocTangLuongKey entityKey  = new GiangVienMocTangLuongKey();
					entityKey.Load(values);
					item = GiangVienMocTangLuongProvider.Get(entityKey);
					results = new TList<GiangVienMocTangLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienMocTangLuongSelectMethod.GetAll:
                    results = GiangVienMocTangLuongProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienMocTangLuongSelectMethod.GetPaged:
					results = GiangVienMocTangLuongProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienMocTangLuongSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienMocTangLuongProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienMocTangLuongProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienMocTangLuongSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = GiangVienMocTangLuongProvider.GetById(_id);
					results = new TList<GiangVienMocTangLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case GiangVienMocTangLuongSelectMethod.GetByMaGiangVien:
					_maGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					results = GiangVienMocTangLuongProvider.GetByMaGiangVien(_maGiangVien_nullable, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == GiangVienMocTangLuongSelectMethod.Get || SelectMethod == GiangVienMocTangLuongSelectMethod.GetById )
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
				GiangVienMocTangLuong entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienMocTangLuongProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienMocTangLuong> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienMocTangLuongProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienMocTangLuongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienMocTangLuongDataSource class.
	/// </summary>
	public class GiangVienMocTangLuongDataSourceDesigner : ProviderDataSourceDesigner<GiangVienMocTangLuong, GiangVienMocTangLuongKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienMocTangLuongDataSourceDesigner class.
		/// </summary>
		public GiangVienMocTangLuongDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienMocTangLuongSelectMethod SelectMethod
		{
			get { return ((GiangVienMocTangLuongDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienMocTangLuongDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienMocTangLuongDataSourceActionList

	/// <summary>
	/// Supports the GiangVienMocTangLuongDataSourceDesigner class.
	/// </summary>
	internal class GiangVienMocTangLuongDataSourceActionList : DesignerActionList
	{
		private GiangVienMocTangLuongDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienMocTangLuongDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienMocTangLuongDataSourceActionList(GiangVienMocTangLuongDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienMocTangLuongSelectMethod SelectMethod
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

	#endregion GiangVienMocTangLuongDataSourceActionList
	
	#endregion GiangVienMocTangLuongDataSourceDesigner
	
	#region GiangVienMocTangLuongSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienMocTangLuongDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienMocTangLuongSelectMethod
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
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien
	}
	
	#endregion GiangVienMocTangLuongSelectMethod

	#region GiangVienMocTangLuongFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienMocTangLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienMocTangLuongFilter : SqlFilter<GiangVienMocTangLuongColumn>
	{
	}
	
	#endregion GiangVienMocTangLuongFilter

	#region GiangVienMocTangLuongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienMocTangLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienMocTangLuongExpressionBuilder : SqlExpressionBuilder<GiangVienMocTangLuongColumn>
	{
	}
	
	#endregion GiangVienMocTangLuongExpressionBuilder	

	#region GiangVienMocTangLuongProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienMocTangLuongChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienMocTangLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienMocTangLuongProperty : ChildEntityProperty<GiangVienMocTangLuongChildEntityTypes>
	{
	}
	
	#endregion GiangVienMocTangLuongProperty
}

