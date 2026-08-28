# PileUtilizeCheckTool - Excel Add-In (Excel-DNA)

## 📋 Cấu trúc dự án

```
PileUtilizeCheckTool/
├── PileUtilizeCheck.ExcelAddIn/          ← Excel-DNA Add-In Project (MAIN)
│   ├── AddIn/
│   │   └── Functions.vb                  ← UDF Functions
│   ├── Ribbon/
│   │   └── RibbonUI.vb                   ← Ribbon UI Handlers
│   ├── My Project/
│   ├── Properties/
│   ├── PileUtilizeCheck.ExcelAddIn.dna   ← DNA Config
│   ├── PileUtilizeCheck.ExcelAddIn.vbproj
│   └── packages.config
│
├── PileUtilizeCheck.Application/         ← Business Logic
├── PileUtilizeCheck.Geometry/            ← Geometry Calculations
├── PileUtilizeCheck.Infrastructure/      ← Infrastructure Layer
├── PileUtilizeCheck.Shared/              ← Shared Utilities
├── PileUtilizeCheck.Domain/              ← Domain Models
│
└── PileUtilizeCheck.sln                  ← Solution File
```

## 🚀 Hướng dẫn sử dụng

### 1. Set startup project
```
Chuột phải trên PileUtilizeCheck.ExcelAddIn → Set as Startup Project
```

### 2. Build solution
```
Build → Build Solution (Ctrl+Shift+B)
```
Output: 
- `PileUtilizeCheck.ExcelAddIn.xll` (64-bit)
- `PileUtilizeCheck.ExcelAddIn.xll` (32-bit)

### 3. Debug in Excel
```
Nhấn F5 hoặc Debug → Start Debugging
```
- Excel sẽ tự mở với Add-In được load
- Test UDF functions từ Functions.vb
- Ribbon tab "Pile Utilize" sẽ hiển thị

### 4. Sử dụng các UDF trong Excel
```excel
=TestAdd(5, 10)                              → Returns 15
=CalculatePileUtilization(500, 1000)         → Returns 50
```

## 🔗 Thêm logic từ các project khác

Thêm Project References vào `PileUtilizeCheck.ExcelAddIn.vbproj`:

```xml
<ItemGroup>
  <ProjectReference Include="..\PileUtilizeCheck.Application\PileUtilizeCheck.Application.vbproj" />
  <ProjectReference Include="..\PileUtilizeCheck.Geometry\PileUtilizeCheck.Geometry.vbproj" />
  <ProjectReference Include="..\PileUtilizeCheck.Infrastructure\PileUtilizeCheck.Infrastructure.vbproj" />
  <ProjectReference Include="..\PileUtilizeCheck.Shared\PileUtilizeCheck.Shared.vbproj" />
  <ProjectReference Include="..\PileUtilizeCheck.Domain\PileUtilizeCheck.Domain.vbproj" />
</ItemGroup>
```

## 📝 Các file quan trọng

| File | Mục đích |
|------|----------|
| `PileUtilizeCheck.ExcelAddIn.dna` | Cấu hình Excel-DNA (Ribbon, External Libraries) |
| `AddIn/Functions.vb` | Chứa các UDF (User Defined Functions) |
| `Ribbon/RibbonUI.vb` | Ribbon button handlers |
| `packages.config` | NuGet dependencies |

## ✨ Tiếp theo

1. ✅ **Add project references** để dùng logic từ các project khác
2. 📝 **Viết thêm UDF functions** trong `AddIn/Functions.vb`
3. 🎨 **Customize Ribbon UI** trong `Ribbon/RibbonUI.vb` + `.dna`
4. 🧪 **Test trong Excel** - F5 để debug

## 🛠️ Troubleshooting

**Lỗi: "Target Framework not supported"**
- Update `.NET Framework` lên 4.7.2 hoặc 4.8
- Hoặc download .NET Framework targeting pack

**Excel không load Add-in**
- Kiểm tra security settings của Excel
- Enable "Trust Center" settings
- Rebuild solution

**UDF function không hiển thị**
- Restart Excel
- Clean + Rebuild solution
- Kiểm tra `ExcelFunction` attribute
