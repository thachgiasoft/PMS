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
	/// Represents the DataRepository.PhanLoaiGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(PhanLoaiGiangVienDataSourceDesigner))]
	public class PhanLoaiGiangVienDataSource : ProviderDataSource<PhanLoaiGiangVien, PhanLoaiGiangVienKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanLoaiGiangVienDataSource class.
		/// </summary>
		public PhanLoaiGiangVienDataSource() : base(new PhanLoaiGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the PhanLoaiGiangVienDataSourceView used by the PhanLoaiGiangVienDataSource.
		/// </summary>
		protected PhanLoaiGiangVienDataSourceView PhanLoaiGiangVienView
		{
			get { return ( View as PhanLoaiGiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the PhanLoaiGiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public PhanLoaiGiangVienSelectMethod SelectMethod
		{
			get
			{
				PhanLoaiGiangVienSelectMethod selectMethod = PhanLoaiGiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (PhanLoaiGiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the PhanLoaiGiangVienDataSourceView class that is to be
		/// used by the PhanLoaiGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the PhanLoaiGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<PhanLoaiGiangVien, PhanLoaiGiangVienKey> GetNewDataSourceView()
		{
			return new PhanLoaiGiangVienDataSourceView(this, DefaultViewName);
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
	/// Supports the PhanLoaiGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class PhanLoaiGiangVienDataSourceView : ProviderDataSourceView<PhanLoaiGiangVien, PhanLoaiGiangVienKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanLoaiGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the PhanLoaiGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public PhanLoaiGiangVienDataSourceView(PhanLoaiGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal PhanLoaiGiangVienDataSource PhanLoaiGiangVienOwner
		{
			get { return Owner as PhanLoaiGiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal PhanLoaiGiangVienSelectMethod SelectMethod
		{
			get { return PhanLoaiGiangVienOwner.SelectMethod; }
			set { PhanLoaiGiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal PhanLoaiGiangVienService PhanLoaiGiangVienProvider
		{
			get { return Provider as PhanLoaiGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<PhanLoaiGiangVien> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<PhanLoaiGiangVien> results = null;
			PhanLoaiGiangVien item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case PhanLoaiGiangVienSelectMethod.Get:
					PhanLoaiGiangVienKey entityKey  = new PhanLoaiGiangVienKey();
					entityKey.Load(values);
					item = PhanLoaiGiangVienProvider.Get(entityKey);
					results = new TList<PhanLoaiGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case PhanLoaiGiangVienSelectMethod.GetAll:
                    results = PhanLoaiGiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case PhanLoaiGiangVienSelectMethod.GetPaged:
					results = PhanLoaiGiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case PhanLoaiGiangVienSelectMethod.Find:
					if ( FilterParameters != null )
						results = PhanLoaiGiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = PhanLoaiGiangVienProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case PhanLoaiGiangVienSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = PhanLoaiGiangVienProvider.GetById(_id);
					results = new TList<PhanLoaiGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
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
			if ( SelectMethod == PhanLoaiGiangVienSelectMethod.Get || SelectMethod == PhanLoaiGiangVienSelectMethod.GetById )
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
				PhanLoaiGiangVien entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					PhanLoaiGiangVienProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<PhanLoaiGiangVien> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			PhanLoaiGiangVienProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region PhanLoaiGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the PhanLoaiGiangVienDataSource class.
	/// </summary>
	public class PhanLoaiGiangVienDataSourceDesigner : ProviderDataSourceDesigner<PhanLoaiGiangVien, PhanLoaiGiangVienKey>
	{
		/// <summary>
		/// Initializes a new instance of the PhanLoaiGiangVienDataSourceDesigner class.
		/// </summary>
		public PhanLoaiGiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public PhanLoaiGiangVienSelectMethod SelectMethod
		{
			get { return ((PhanLoaiGiangVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new PhanLoaiGiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region PhanLoaiGiangVienDataSourceActionList

	/// <summary>
	/// Supports the PhanLoaiGiangVienDataSourceDesigner class.
	/// </summary>
	internal class PhanLoaiGiangVienDataSourceActionList : DesignerActionList
	{
		private PhanLoaiGiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the PhanLoaiGiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public PhanLoaiGiangVienDataSourceActionList(PhanLoaiGiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public PhanLoaiGiangVienSelectMethod SelectMethod
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

	#endregion PhanLoaiGiangVienDataSourceActionList
	
	#endregion PhanLoaiGiangVienDataSourceDesigner
	
	#region PhanLoaiGiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the PhanLoaiGiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum PhanLoaiGiangVienSelectMethod
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
		GetById
	}
	
	#endregion PhanLoaiGiangVienSelectMethod

	#region PhanLoaiGiangVienFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanLoaiGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanLoaiGiangVienFilter : SqlFilter<PhanLoaiGiangVienColumn>
	{
	}
	
	#endregion PhanLoaiGiangVienFilter

	#region PhanLoaiGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanLoaiGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanLoaiGiangVienExpressionBuilder : SqlExpressionBuilder<PhanLoaiGiangVienColumn>
	{
	}
	
	#endregion PhanLoaiGiangVienExpressionBuilder	

	#region PhanLoaiGiangVienProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;PhanLoaiGiangVienChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="PhanLoaiGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanLoaiGiangVienProperty : ChildEntityProperty<PhanLoaiGiangVienChildEntityTypes>
	{
	}
	
	#endregion PhanLoaiGiangVienProperty
}

