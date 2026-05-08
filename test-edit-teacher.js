// test-edit-teacher.js
// اختبار دالة تعديل الأستاذ - حالتين (صحيحة وخاطئة)

// استيراد الدالة من ملف app.js (تأكدي أن الدالة موجودة ومصدّرة)
const { editTeacher } = require('./app.js');

let passCount = 0;
let failCount = 0;

console.log("🔍 بدء اختبار تعديل الأستاذ...\n");

// === الحالة الأولى (صحيحة): تعديل أستاذ موجود ===
console.log("✅ الاختبار 1 (صحيح): تعديل أستاذ موجود - نتوقع success=true");
try {
    const result = editTeacher(1, "أحمد الجديد");
    if (result && result.success === true) {
        console.log("   → نجح: تم التعديل كما هو متوقع");
        passCount++;
    } else {
        console.log("   → فشل: لم ترجع الدالة success=true");
        failCount++;
    }
} catch (err) {
    console.log("   → خطأ في الكود: " + err.message);
    failCount++;
}

// === الحالة الثانية (خاطئة): تعديل أستاذ غير موجود ===
console.log("\n❌ الاختبار 2 (خاطئ): تعديل أستاذ غير موجود - نتوقع success=false");
try {
    const result = editTeacher(999, "غير موجود");
    if (result && result.success === false) {
        console.log("   → نجح: الدالة فشلت كما هو متوقع");
        passCount++;
    } else {
        console.log("   → فشل: الدالة نجحت رغم أن الأستاذ غير موجود");
        failCount++;
    }
} catch (err) {
    console.log("   → خطأ في الكود: " + err.message);
    failCount++;
}

// النتيجة النهائية
console.log(\n🏁 الإجمالي: ${passCount} نجاح, ${failCount} فشل);
process.exit(failCount > 0 ? 1 : 0);