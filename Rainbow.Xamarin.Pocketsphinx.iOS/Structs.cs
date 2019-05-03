using System;
using System.Runtime.InteropServices;

namespace Pocketsphinx
{
    public enum agc_type_t : uint
    {
        None = 0,
        Max,
        Emax,
        Noise
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct agc_t
    {
        public int max;

        public int obs_max;

        public int obs_frame;

        public int obs_utt;

        public int obs_max_sum;

        public int noise_thresh;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct bitarr_mask_t
    {
        public int bits;

        public int mask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct bitarr_address_t
    {
        public unsafe void* @base;

        public int offset;
    }

    //static class CFunctions
    //{
    //    // extern jmp_buf * ckd_set_jump (jmp_buf *env, int abort);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int[]* ckd_set_jump(int[]* env, int abort);

    //    // extern void ckd_fail (char *format, ...);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ckd_fail(sbyte* format, IntPtr varArgs);

    //    // extern int sgemm_ (char *transa, char *transb, integer *m, integer *n, integer *k, real *alpha, real *a, integer *lda, real *b, integer *ldb, real *beta, real *c__, integer *ldc);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int sgemm_(sbyte* transa, sbyte* transb, int* m, int* n, int* k, float* alpha, float* a, int* lda, float* b, int* ldb, float* beta, float* c__, int* ldc);

    //    // extern int sgemv_ (char *trans, integer *m, integer *n, real *alpha, real *a, integer *lda, real *x, integer *incx, real *beta, real *y, integer *incy);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int sgemv_(sbyte* trans, int* m, int* n, float* alpha, float* a, int* lda, float* x, int* incx, float* beta, float* y, int* incy);

    //    // extern int ssymm_ (char *side, char *uplo, integer *m, integer *n, real *alpha, real *a, integer *lda, real *b, integer *ldb, real *beta, real *c__, integer *ldc);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ssymm_(sbyte* side, sbyte* uplo, int* m, int* n, float* alpha, float* a, int* lda, float* b, int* ldb, float* beta, float* c__, int* ldc);

    //    // extern int sposv_ (char *uplo, integer *n, integer *nrhs, real *a, integer *lda, real *b, integer *ldb, integer *info);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int sposv_(sbyte* uplo, int* n, int* nrhs, float* a, int* lda, float* b, int* ldb, int* info);

    //    // extern int spotrf_ (char *uplo, integer *n, real *a, integer *lda, integer *info);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int spotrf_(sbyte* uplo, int* n, float* a, int* lda, int* info);

    //    // extern cmd_ln_t * cmd_ln_init (cmd_ln_t *inout_cmdln, const arg_t *defn, int strict, ...);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe cmd_ln_t* cmd_ln_init(cmd_ln_t* inout_cmdln, arg_t* defn, int strict, IntPtr varArgs);

    //    // extern cmd_ln_t * cmd_ln_retain (cmd_ln_t *cmdln);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe cmd_ln_t* cmd_ln_retain(cmd_ln_t* cmdln);

    //    // extern int cmd_ln_free_r (cmd_ln_t *cmdln);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int cmd_ln_free_r(cmd_ln_t* cmdln);

    //    // extern cmd_ln_t * cmd_ln_parse_r (cmd_ln_t *inout_cmdln, const arg_t *defn, int argc, char **argv, int strict);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe cmd_ln_t* cmd_ln_parse_r(cmd_ln_t* inout_cmdln, arg_t* defn, int argc, sbyte*[] argv, int strict);

    //    // extern cmd_ln_t * cmd_ln_parse_file_r (cmd_ln_t *inout_cmdln, const arg_t *defn, const char *filename, int strict);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe cmd_ln_t* cmd_ln_parse_file_r(cmd_ln_t* inout_cmdln, arg_t* defn, sbyte* filename, int strict);

    //    // extern anytype_t * cmd_ln_access_r (cmd_ln_t *cmdln, const char *name);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe anytype_t* cmd_ln_access_r(cmd_ln_t* cmdln, sbyte* name);

    //    // extern const char * cmd_ln_str_r (cmd_ln_t *cmdln, const char *name);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* cmd_ln_str_r(cmd_ln_t* cmdln, sbyte* name);

    //    // extern const char ** cmd_ln_str_list_r (cmd_ln_t *cmdln, const char *name);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte** cmd_ln_str_list_r(cmd_ln_t* cmdln, sbyte* name);

    //    // extern long cmd_ln_int_r (cmd_ln_t *cmdln, const char *name);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe nint cmd_ln_int_r(cmd_ln_t* cmdln, sbyte* name);

    //    // extern double cmd_ln_float_r (cmd_ln_t *cmdln, const char *name);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe double cmd_ln_float_r(cmd_ln_t* cmdln, sbyte* name);

    //    // extern void cmd_ln_set_str_r (cmd_ln_t *cmdln, const char *name, const char *str);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void cmd_ln_set_str_r(cmd_ln_t* cmdln, sbyte* name, sbyte* str);

    //    // extern void cmd_ln_set_str_extra_r (cmd_ln_t *cmdln, const char *name, const char *str);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void cmd_ln_set_str_extra_r(cmd_ln_t* cmdln, sbyte* name, sbyte* str);

    //    // extern void cmd_ln_set_int_r (cmd_ln_t *cmdln, const char *name, long iv);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void cmd_ln_set_int_r(cmd_ln_t* cmdln, sbyte* name, nint iv);

    //    // extern void cmd_ln_set_float_r (cmd_ln_t *cmdln, const char *name, double fv);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void cmd_ln_set_float_r(cmd_ln_t* cmdln, sbyte* name, double fv);

    //    // extern int cmd_ln_exists_r (cmd_ln_t *cmdln, const char *name);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int cmd_ln_exists_r(cmd_ln_t* cmdln, sbyte* name);

    //    // extern void cmd_ln_print_help_r (cmd_ln_t *cmdln, FILE *fp, const arg_t *defn);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void cmd_ln_print_help_r(cmd_ln_t* cmdln, FILE* fp, arg_t* defn);

    //    // extern void cmd_ln_print_values_r (cmd_ln_t *cmdln, FILE *fp, const arg_t *defn);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void cmd_ln_print_values_r(cmd_ln_t* cmdln, FILE* fp, arg_t* defn);

    //    // extern int cmd_ln_parse (const arg_t *defn, int argc, char **argv, int strict);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int cmd_ln_parse(arg_t* defn, int argc, sbyte*[] argv, int strict);

    //    // extern int cmd_ln_parse_file (const arg_t *defn, const char *filename, int strict);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int cmd_ln_parse_file(arg_t* defn, sbyte* filename, int strict);

    //    // extern void cmd_ln_appl_enter (int argc, char **argv, const char *default_argfn, const arg_t *defn);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void cmd_ln_appl_enter(int argc, sbyte*[] argv, sbyte* default_argfn, arg_t* defn);

    //    // extern void cmd_ln_appl_exit ();
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern void cmd_ln_appl_exit();

    //    // extern cmd_ln_t * cmd_ln_get ();
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe cmd_ln_t* cmd_ln_get();

    //    // extern void cmd_ln_free ();
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern void cmd_ln_free();

    //    // extern cmn_type_t cmn_type_from_str (const char *str);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe cmn_type_t cmn_type_from_str(sbyte* str);

    //    // extern cmn_t * cmn_init (int veclen);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe cmn_t* cmn_init(int veclen);

    //    // extern void cmn (cmn_t *cmn, int **mfc, int varnorm, int n_frame);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void cmn(cmn_t* cmn, int** mfc, int varnorm, int n_frame);

    //    // extern void cmn_live (cmn_t *cmn, int **incep, int varnorm, int nfr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void cmn_live(cmn_t* cmn, int** incep, int varnorm, int nfr);

    //    // extern void cmn_live_update (cmn_t *cmn);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void cmn_live_update(cmn_t* cmn);

    //    // extern void cmn_live_set (cmn_t *cmn, int);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void cmn_live_set(cmn_t* cmn, int);

    //    // extern void cmn_live_get (cmn_t *cmn, int *vec);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void cmn_live_get(cmn_t* cmn, int* vec);

    //    // extern void cmn_free (cmn_t *cmn);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void cmn_free(cmn_t* cmn);

    //    // extern void err_msg (err_lvl_t lvl, const char *path, long ln, const char *fmt, ...);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void err_msg(err_lvl_t lvl, sbyte* path, nint ln, sbyte* fmt, IntPtr varArgs);

    //    // extern void err_msg_system (err_lvl_t lvl, const char *path, long ln, const char *fmt, ...);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void err_msg_system(err_lvl_t lvl, sbyte* path, nint ln, sbyte* fmt, IntPtr varArgs);

    //    // extern void err_logfp_cb (void *user_data, err_lvl_t level, const char *fmt, ...);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void err_logfp_cb(void* user_data, err_lvl_t level, sbyte* fmt, IntPtr varArgs);

    //    // extern void err_set_callback (err_cb_f callback, void *user_data);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void err_set_callback(err_cb_f* callback, void* user_data);

    //    // extern void err_set_logfp (FILE *stream);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void err_set_logfp(FILE* stream);

    //    // extern FILE * err_get_logfp ();
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe FILE* err_get_logfp();

    //    // extern int err_set_logfile (const char *path);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int err_set_logfile(sbyte* path);

    //    // extern int err_set_debug_level (int level);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern int err_set_debug_level(int level);

    //    // extern int err_get_debug_level ();
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern int err_get_debug_level();

    //    // extern fe_t * fe_init_auto ();
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe fe_t* fe_init_auto();

    //    // extern const arg_t * fe_get_args ();
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe arg_t* fe_get_args();

    //    // extern fe_t * fe_init_auto_r (cmd_ln_t *config);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe fe_t* fe_init_auto_r(cmd_ln_t* config);

    //    // extern const cmd_ln_t * fe_get_config (fe_t *fe);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe cmd_ln_t* fe_get_config(fe_t* fe);

    //    // extern void fe_start_stream (fe_t *fe);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void fe_start_stream(fe_t* fe);

    //    // extern int fe_start_utt (fe_t *fe);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fe_start_utt(fe_t* fe);

    //    // extern int fe_get_output_size (fe_t *fe);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fe_get_output_size(fe_t* fe);

    //    // extern void fe_get_input_size (fe_t *fe, int *out_frame_shift, int *out_frame_size);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void fe_get_input_size(fe_t* fe, int* out_frame_shift, int* out_frame_size);

    //    // extern int fe_get_vad_state (fe_t *fe);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fe_get_vad_state(fe_t* fe);

    //    // extern int fe_end_utt (fe_t *fe, mfcc_t *out_cepvector, int *out_nframes);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fe_end_utt(fe_t* fe, int* out_cepvector, int* out_nframes);

    //    // extern fe_t * fe_retain (fe_t *fe);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe fe_t* fe_retain(fe_t* fe);

    //    // extern int fe_free (fe_t *fe);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fe_free(fe_t* fe);

    //    // extern int fe_process_frames_ext (fe_t *fe, int);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fe_process_frames_ext(fe_t* fe, int);

    //    // extern int fe_process_frames (fe_t *fe, int);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fe_process_frames(fe_t* fe, int);

    //    // extern int fe_process_utt (fe_t *fe, int);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fe_process_utt(fe_t* fe, int);

    //    // extern void fe_free_2d (void *arr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void fe_free_2d(void* arr);

    //    // extern int fe_mfcc_to_float (fe_t *fe, mfcc_t **input, int **output, int nframes);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fe_mfcc_to_float(fe_t* fe, int** input, int** output, int nframes);

    //    // extern int fe_float_to_mfcc (fe_t *fe, int **input, mfcc_t **output, int nframes);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fe_float_to_mfcc(fe_t* fe, int** input, int** output, int nframes);

    //    // extern int fe_logspec_to_mfcc (fe_t *fe, const mfcc_t *fr_spec, mfcc_t *fr_cep);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fe_logspec_to_mfcc(fe_t* fe, int* fr_spec, int* fr_cep);

    //    // extern int fe_logspec_dct2 (fe_t *fe, const mfcc_t *fr_spec, mfcc_t *fr_cep);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fe_logspec_dct2(fe_t* fe, int* fr_spec, int* fr_cep);

    //    // extern int fe_mfcc_dct3 (fe_t *fe, const mfcc_t *fr_cep, mfcc_t *fr_spec);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fe_mfcc_dct3(fe_t* fe, int* fr_cep, int* fr_spec);

    //    // extern int ** parse_subvecs (const char *str);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int** parse_subvecs(sbyte* str);

    //    // extern void subvecs_free (int **subvecs);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void subvecs_free(int** subvecs);

    //    // extern mfcc_t *** feat_array_alloc (feat_t *fcb, int nfr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int*** feat_array_alloc(feat_t* fcb, int nfr);

    //    // extern mfcc_t *** feat_array_realloc (feat_t *fcb, mfcc_t ***old_feat, int ofr, int nfr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int*** feat_array_realloc(feat_t* fcb, int*** old_feat, int ofr, int nfr);

    //    // extern void feat_array_free (mfcc_t ***feat);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void feat_array_free(int*** feat);

    //    // extern feat_t * feat_init (const char *type, cmn_type_t cmn, int varnorm, agc_type_t agc, int breport, int cepsize);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe feat_t* feat_init(sbyte* type, cmn_type_t cmn, int varnorm, agc_type_t agc, int breport, int cepsize);

    //    // extern int feat_read_lda (feat_t *feat, const char *ldafile, int dim);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int feat_read_lda(feat_t* feat, sbyte* ldafile, int dim);

    //    // extern void feat_lda_transform (feat_t *fcb, mfcc_t ***inout_feat, int nfr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void feat_lda_transform(feat_t* fcb, int*** inout_feat, int nfr);

    //    // extern int feat_set_subvecs (feat_t *fcb, int **subvecs);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int feat_set_subvecs(feat_t* fcb, int** subvecs);

    //    // extern void feat_print (feat_t *fcb, mfcc_t ***feat, int nfr, FILE *fp);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void feat_print(feat_t* fcb, int*** feat, int nfr, FILE* fp);

    //    // extern int feat_s2mfc2feat (feat_t *fcb, const char *file, const char *dir, const char *cepext, int sf, int ef, mfcc_t ***feat, int maxfr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int feat_s2mfc2feat(feat_t* fcb, sbyte* file, sbyte* dir, sbyte* cepext, int sf, int ef, int*** feat, int maxfr);

    //    // extern int feat_s2mfc2feat_live (feat_t *fcb, mfcc_t **uttcep, int *inout_ncep, int beginutt, int endutt, mfcc_t ***ofeat);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int feat_s2mfc2feat_live(feat_t* fcb, int** uttcep, int* inout_ncep, int beginutt, int endutt, int*** ofeat);

    //    // extern void feat_update_stats (feat_t *fcb);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void feat_update_stats(feat_t* fcb);

    //    // extern feat_t * feat_retain (feat_t *f);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe feat_t* feat_retain(feat_t* f);

    //    // extern int feat_free (feat_t *f);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int feat_free(feat_t* f);

    //    // extern void feat_report (feat_t *f);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void feat_report(feat_t* f);

    //    // extern const char * path2basename (const char *path);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* path2basename(sbyte* path);

    //    // extern void path2dirname (const char *path, char *dir);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void path2dirname(sbyte* path, sbyte* dir);

    //    // extern void strip_fileext (const char *file, char *root);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void strip_fileext(sbyte* file, sbyte* root);

    //    // extern int path_is_absolute (const char *file);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int path_is_absolute(sbyte* file);

    //    // extern int fixlog (int x);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern int fixlog(int x);

    //    // extern int fixlog2 (int x);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern int fixlog2(int x);

    //    // extern fsg_model_t * fsg_model_init (const char *name, int *lmath, int lw, int n_state);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe fsg_model_t* fsg_model_init(sbyte* name, int* lmath, int lw, int n_state);

    //    // extern fsg_model_t * fsg_model_readfile (const char *file, int *lmath, int lw);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe fsg_model_t* fsg_model_readfile(sbyte* file, int* lmath, int lw);

    //    // extern fsg_model_t * fsg_model_read (FILE *fp, int *lmath, int lw);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe fsg_model_t* fsg_model_read(FILE* fp, int* lmath, int lw);

    //    // extern fsg_model_t * fsg_model_retain (fsg_model_t *fsg);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe fsg_model_t* fsg_model_retain(fsg_model_t* fsg);

    //    // extern int fsg_model_free (fsg_model_t *fsg);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fsg_model_free(fsg_model_t* fsg);

    //    // extern int fsg_model_word_add (fsg_model_t *fsg, const char *word);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fsg_model_word_add(fsg_model_t* fsg, sbyte* word);

    //    // extern int fsg_model_word_id (fsg_model_t *fsg, const char *word);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fsg_model_word_id(fsg_model_t* fsg, sbyte* word);

    //    // extern void fsg_model_trans_add (fsg_model_t *fsg, int from, int to, int logp, int wid);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void fsg_model_trans_add(fsg_model_t* fsg, int from, int to, int logp, int wid);

    //    // extern int fsg_model_null_trans_add (fsg_model_t *fsg, int from, int to, int logp);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fsg_model_null_trans_add(fsg_model_t* fsg, int from, int to, int logp);

    //    // extern int fsg_model_tag_trans_add (fsg_model_t *fsg, int from, int to, int logp, int wid);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fsg_model_tag_trans_add(fsg_model_t* fsg, int from, int to, int logp, int wid);

    //    // extern int fsg_model_null_trans_closure (fsg_model_t *fsg, int nulls);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fsg_model_null_trans_closure(fsg_model_t* fsg, int nulls);

    //    // extern int fsg_model_trans (fsg_model_t *fsg, int i, int j);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fsg_model_trans(fsg_model_t* fsg, int i, int j);

    //    // extern fsg_arciter_t * fsg_model_arcs (fsg_model_t *fsg, int i);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe fsg_arciter_t* fsg_model_arcs(fsg_model_t* fsg, int i);

    //    // extern fsg_link_t * fsg_arciter_get (fsg_arciter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe fsg_link_t* fsg_arciter_get(fsg_arciter_t* itor);

    //    // extern fsg_arciter_t * fsg_arciter_next (fsg_arciter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe fsg_arciter_t* fsg_arciter_next(fsg_arciter_t* itor);

    //    // extern void fsg_arciter_free (fsg_arciter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void fsg_arciter_free(fsg_arciter_t* itor);

    //    // extern fsg_link_t * fsg_model_null_trans (fsg_model_t *fsg, int i, int j);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe fsg_link_t* fsg_model_null_trans(fsg_model_t* fsg, int i, int j);

    //    // extern int fsg_model_add_silence (fsg_model_t *fsg, const char *silword, int state, int silprob);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fsg_model_add_silence(fsg_model_t* fsg, sbyte* silword, int state, int silprob);

    //    // extern int fsg_model_add_alt (fsg_model_t *fsg, const char *baseword, const char *altword);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fsg_model_add_alt(fsg_model_t* fsg, sbyte* baseword, sbyte* altword);

    //    // extern void fsg_model_write (fsg_model_t *fsg, FILE *fp);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void fsg_model_write(fsg_model_t* fsg, FILE* fp);

    //    // extern void fsg_model_writefile (fsg_model_t *fsg, const char *file);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void fsg_model_writefile(fsg_model_t* fsg, sbyte* file);

    //    // extern void fsg_model_write_fsm (fsg_model_t *fsg, FILE *fp);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void fsg_model_write_fsm(fsg_model_t* fsg, FILE* fp);

    //    // extern void fsg_model_writefile_fsm (fsg_model_t *fsg, const char *file);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void fsg_model_writefile_fsm(fsg_model_t* fsg, sbyte* file);

    //    // extern void fsg_model_write_symtab (fsg_model_t *fsg, FILE *file);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void fsg_model_write_symtab(fsg_model_t* fsg, FILE* file);

    //    // extern void fsg_model_writefile_symtab (fsg_model_t *fsg, const char *file);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void fsg_model_writefile_symtab(fsg_model_t* fsg, sbyte* file);

    //    // extern void genrand_seed (unsigned long s);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern void genrand_seed(nuint s);

    //    // extern long genrand_int31 ();
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern nint genrand_int31();

    //    // extern double genrand_real3 ();
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern double genrand_real3();

    //    // extern double genrand_res53 ();
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern double genrand_res53();

    //    // extern glist_t glist_add_ptr (glist_t g, void *ptr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe glist_t* glist_add_ptr(glist_t* g, void* ptr);

    //    // extern glist_t glist_add_int32 (glist_t g, int val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe glist_t* glist_add_int32(glist_t* g, int val);

    //    // extern glist_t glist_add_uint32 (glist_t g, int val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe glist_t* glist_add_uint32(glist_t* g, int val);

    //    // extern glist_t glist_add_float32 (glist_t g, int val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe glist_t* glist_add_float32(glist_t* g, int val);

    //    // extern glist_t glist_add_float64 (glist_t g, float64 val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe glist_t* glist_add_float64(glist_t* g, double val);

    //    // extern gnode_t * glist_insert_ptr (gnode_t *gn, void *ptr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe gnode_t* glist_insert_ptr(gnode_t* gn, void* ptr);

    //    // extern gnode_t * glist_insert_int32 (gnode_t *gn, int val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe gnode_t* glist_insert_int32(gnode_t* gn, int val);

    //    // extern gnode_t * glist_insert_uint32 (gnode_t *gn, int val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe gnode_t* glist_insert_uint32(gnode_t* gn, int val);

    //    // extern gnode_t * glist_insert_float32 (gnode_t *gn, int val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe gnode_t* glist_insert_float32(gnode_t* gn, int val);

    //    // extern gnode_t * glist_insert_float64 (gnode_t *gn, float64 val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe gnode_t* glist_insert_float64(gnode_t* gn, double val);

    //    // extern glist_t glist_reverse (glist_t g);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe glist_t* glist_reverse(glist_t* g);

    //    // extern int glist_count (glist_t g);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int glist_count(glist_t* g);

    //    // extern void glist_free (glist_t g);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void glist_free(glist_t* g);

    //    // extern gnode_t * gnode_free (gnode_t *gn, gnode_t *pred);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe gnode_t* gnode_free(gnode_t* gn, gnode_t* pred);

    //    // extern gnode_t * glist_tail (glist_t g);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe gnode_t* glist_tail(glist_t* g);

    //    // extern hash_table_t * hash_table_new (int size, int casearg);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe hash_table_t* hash_table_new(int size, int casearg);

    //    // extern void hash_table_free (hash_table_t *h);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void hash_table_free(hash_table_t* h);

    //    // extern void * hash_table_enter (hash_table_t *h, const char *key, void *val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void* hash_table_enter(hash_table_t* h, sbyte* key, void* val);

    //    // extern void * hash_table_replace (hash_table_t *h, const char *key, void *val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void* hash_table_replace(hash_table_t* h, sbyte* key, void* val);

    //    // extern void * hash_table_delete (hash_table_t *h, const char *key);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void* hash_table_delete(hash_table_t* h, sbyte* key);

    //    // extern void * hash_table_delete_bkey (hash_table_t *h, const char *key, size_t len);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void* hash_table_delete_bkey(hash_table_t* h, sbyte* key, nuint len);

    //    // extern void hash_table_empty (hash_table_t *h);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void hash_table_empty(hash_table_t* h);

    //    // extern void * hash_table_enter_bkey (hash_table_t *h, const char *key, size_t len, void *val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void* hash_table_enter_bkey(hash_table_t* h, sbyte* key, nuint len, void* val);

    //    // extern void * hash_table_replace_bkey (hash_table_t *h, const char *key, size_t len, void *val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void* hash_table_replace_bkey(hash_table_t* h, sbyte* key, nuint len, void* val);

    //    // extern int hash_table_lookup (hash_table_t *h, const char *key, void **val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int hash_table_lookup(hash_table_t* h, sbyte* key, void** val);

    //    // extern int hash_table_lookup_int32 (hash_table_t *h, const char *key, int *val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int hash_table_lookup_int32(hash_table_t* h, sbyte* key, int* val);

    //    // extern int hash_table_lookup_bkey (hash_table_t *h, const char *key, size_t len, void **val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int hash_table_lookup_bkey(hash_table_t* h, sbyte* key, nuint len, void** val);

    //    // extern int hash_table_lookup_bkey_int32 (hash_table_t *h, const char *key, size_t len, int *val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int hash_table_lookup_bkey_int32(hash_table_t* h, sbyte* key, nuint len, int* val);

    //    // extern hash_iter_t * hash_table_iter (hash_table_t *h);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe hash_iter_t* hash_table_iter(hash_table_t* h);

    //    // extern hash_iter_t * hash_table_iter_next (hash_iter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe hash_iter_t* hash_table_iter_next(hash_iter_t* itor);

    //    // extern void hash_table_iter_free (hash_iter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void hash_table_iter_free(hash_iter_t* itor);

    //    // extern glist_t hash_table_tolist (hash_table_t *h, int *count);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe glist_t* hash_table_tolist(hash_table_t* h, int* count);

    //    // extern void hash_table_display (hash_table_t *h, int showkey);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void hash_table_display(hash_table_t* h, int showkey);

    //    // extern heap_t * heap_new ();
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe heap_t* heap_new();

    //    // extern int heap_insert (heap_t *heap, void *data, int val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int heap_insert(heap_t* heap, void* data, int val);

    //    // extern int heap_top (heap_t *heap, void **data, int *val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int heap_top(heap_t* heap, void** data, int* val);

    //    // extern int heap_pop (heap_t *heap, void **data, int *val);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int heap_pop(heap_t* heap, void** data, int* val);

    //    // extern int heap_remove (heap_t *heap, void *data);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int heap_remove(heap_t* heap, void* data);

    //    // extern size_t heap_size (heap_t *heap);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe nuint heap_size(heap_t* heap);

    //    // extern int heap_destroy (heap_t *heap);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int heap_destroy(heap_t* heap);

    //    // extern jsgf_t * jsgf_grammar_new (jsgf_t *parent);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe jsgf_t* jsgf_grammar_new(jsgf_t* parent);

    //    // extern jsgf_t * jsgf_parse_file (const char *filename, jsgf_t *parent);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe jsgf_t* jsgf_parse_file(sbyte* filename, jsgf_t* parent);

    //    // extern jsgf_t * jsgf_parse_string (const char *string, jsgf_t *parent);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe jsgf_t* jsgf_parse_string(sbyte* @string, jsgf_t* parent);

    //    // extern const char * jsgf_grammar_name (jsgf_t *jsgf);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* jsgf_grammar_name(jsgf_t* jsgf);

    //    // extern void jsgf_grammar_free (jsgf_t *jsgf);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void jsgf_grammar_free(jsgf_t* jsgf);

    //    // extern jsgf_rule_iter_t * jsgf_rule_iter (jsgf_t *grammar);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe jsgf_rule_iter_t* jsgf_rule_iter(jsgf_t* grammar);

    //    // extern jsgf_rule_t * jsgf_get_rule (jsgf_t *grammar, const char *name);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe jsgf_rule_t* jsgf_get_rule(jsgf_t* grammar, sbyte* name);

    //    // extern jsgf_rule_t * jsgf_get_public_rule (jsgf_t *grammar);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe jsgf_rule_t* jsgf_get_public_rule(jsgf_t* grammar);

    //    // extern const char * jsgf_rule_name (jsgf_rule_t *rule);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* jsgf_rule_name(jsgf_rule_t* rule);

    //    // extern int jsgf_rule_public (jsgf_rule_t *rule);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int jsgf_rule_public(jsgf_rule_t* rule);

    //    // extern fsg_model_t * jsgf_build_fsg (jsgf_t *grammar, jsgf_rule_t *rule, int *lmath, int lw);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe fsg_model_t* jsgf_build_fsg(jsgf_t* grammar, jsgf_rule_t* rule, int* lmath, int lw);

    //    // extern fsg_model_t * jsgf_build_fsg_raw (jsgf_t *grammar, jsgf_rule_t *rule, int *lmath, int lw);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe fsg_model_t* jsgf_build_fsg_raw(jsgf_t* grammar, jsgf_rule_t* rule, int* lmath, int lw);

    //    // extern fsg_model_t * jsgf_read_file (const char *file, int *lmath, int lw);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe fsg_model_t* jsgf_read_file(sbyte* file, int* lmath, int lw);

    //    // extern fsg_model_t * jsgf_read_string (const char *string, int *lmath, int lw);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe fsg_model_t* jsgf_read_string(sbyte* @string, int* lmath, int lw);

    //    // extern int jsgf_write_fsg (jsgf_t *grammar, jsgf_rule_t *rule, FILE *outfh);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int jsgf_write_fsg(jsgf_t* grammar, jsgf_rule_t* rule, FILE* outfh);

    //    // extern listelem_alloc_t * listelem_alloc_init (size_t elemsize);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe listelem_alloc_t* listelem_alloc_init(nuint elemsize);

    //    // extern void listelem_alloc_free (listelem_alloc_t *le);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void listelem_alloc_free(listelem_alloc_t* le);

    //    // extern void * __listelem_malloc__ (listelem_alloc_t *le, char *file, int line);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void* __listelem_malloc__(listelem_alloc_t* le, sbyte* file, int line);

    //    // extern void * __listelem_malloc_id__ (listelem_alloc_t *le, char *file, int line, int *out_id);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void* __listelem_malloc_id__(listelem_alloc_t* le, sbyte* file, int line, int* out_id);

    //    // extern void * listelem_get_item (listelem_alloc_t *le, int id);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void* listelem_get_item(listelem_alloc_t* le, int id);

    //    // extern void __listelem_free__ (listelem_alloc_t *le, void *elem, char *file, int line);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void __listelem_free__(listelem_alloc_t* le, void* elem, sbyte* file, int line);

    //    // extern void listelem_stats (listelem_alloc_t *le);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void listelem_stats(listelem_alloc_t* le);

    //    // extern logmath_t * logmath_init (float64 base, int shift, int use_table);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe logmath_t* logmath_init(double @base, int shift, int use_table);

    //    // extern logmath_t * logmath_read (const char *filename);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe logmath_t* logmath_read(sbyte* filename);

    //    // extern int logmath_write (logmath_t *lmath, const char *filename);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int logmath_write(logmath_t* lmath, sbyte* filename);

    //    // extern int logmath_get_table_shape (logmath_t *lmath, int *out_size, int *out_width, int *out_shift);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int logmath_get_table_shape(logmath_t* lmath, int* out_size, int* out_width, int* out_shift);

    //    // extern float64 logmath_get_base (logmath_t *lmath);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe double logmath_get_base(logmath_t* lmath);

    //    // extern int logmath_get_zero (logmath_t *lmath);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int logmath_get_zero(logmath_t* lmath);

    //    // extern int logmath_get_width (logmath_t *lmath);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int logmath_get_width(logmath_t* lmath);

    //    // extern int logmath_get_shift (logmath_t *lmath);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int logmath_get_shift(logmath_t* lmath);

    //    // extern logmath_t * logmath_retain (logmath_t *lmath);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe logmath_t* logmath_retain(logmath_t* lmath);

    //    // extern int logmath_free (logmath_t *lmath);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int logmath_free(logmath_t* lmath);

    //    // extern int logmath_add_exact (logmath_t *lmath, int logb_p, int logb_q);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int logmath_add_exact(logmath_t* lmath, int logb_p, int logb_q);

    //    // extern int logmath_add (logmath_t *lmath, int logb_p, int logb_q);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int logmath_add(logmath_t* lmath, int logb_p, int logb_q);

    //    // extern int logmath_log (logmath_t *lmath, float64 p);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int logmath_log(logmath_t* lmath, double p);

    //    // extern float64 logmath_exp (logmath_t *lmath, int logb_p);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe double logmath_exp(logmath_t* lmath, int logb_p);

    //    // extern int logmath_ln_to_log (logmath_t *lmath, float64 log_p);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int logmath_ln_to_log(logmath_t* lmath, double log_p);

    //    // extern float64 logmath_log_to_ln (logmath_t *lmath, int logb_p);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe double logmath_log_to_ln(logmath_t* lmath, int logb_p);

    //    // extern int logmath_log10_to_log (logmath_t *lmath, float64 log_p);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int logmath_log10_to_log(logmath_t* lmath, double log_p);

    //    // extern float logmath_log10_to_log_float (logmath_t *lmath, float64 log_p);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe float logmath_log10_to_log_float(logmath_t* lmath, double log_p);

    //    // extern float64 logmath_log_to_log10 (logmath_t *lmath, int logb_p);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe double logmath_log_to_log10(logmath_t* lmath, int logb_p);

    //    // extern float64 logmath_log_float_to_log10 (logmath_t *lmath, float log_p);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe double logmath_log_float_to_log10(logmath_t* lmath, float log_p);

    //    // extern void norm_3d (int ***arr, int d1, int d2, int d3);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void norm_3d(int*** arr, int d1, int d2, int d3);

    //    // extern void accum_3d (int ***out, int ***in, int d1, int d2, int d3);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void accum_3d(int*** @out, int*** @in, int d1, int d2, int d3);

    //    // extern void band_nz_1d (int *v, int d1, int band);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void band_nz_1d(int* v, int d1, int band);

    //    // extern void floor_nz_3d (int ***m, int d1, int d2, int d3, int floor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void floor_nz_3d(int*** m, int d1, int d2, int d3, int floor);

    //    // extern void floor_nz_1d (int *v, int d1, int floor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void floor_nz_1d(int* v, int d1, int floor);

    //    // extern float64 determinant (int **a, int len);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe double determinant(int** a, int len);

    //    // extern int invert (int **out_ainv, int **a, int len);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int invert(int** out_ainv, int** a, int len);

    //    // extern int solve (int **a, int *b, int *out_x, int n);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int solve(int** a, int* b, int* out_x, int n);

    //    // extern void outerproduct (int **out_a, int *x, int *y, int len);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void outerproduct(int** out_a, int* x, int* y, int len);

    //    // extern void matrixmultiply (int **out_c, int **a, int **b, int n);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void matrixmultiply(int** out_c, int** a, int** b, int n);

    //    // extern void scalarmultiply (int **inout_a, int x, int n);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void scalarmultiply(int** inout_a, int x, int n);

    //    // extern void matrixadd (int **inout_a, int **b, int n);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void matrixadd(int** inout_a, int** b, int n);

    //    // extern mmio_file_t * mmio_file_read (const char *filename);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe mmio_file_t* mmio_file_read(sbyte* filename);

    //    // extern void * mmio_file_ptr (mmio_file_t *mf);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void* mmio_file_ptr(mmio_file_t* mf);

    //    // extern void mmio_file_unmap (mmio_file_t *mf);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void mmio_file_unmap(mmio_file_t* mf);

    //    // extern ngram_model_t * ngram_model_read (cmd_ln_t *config, const char *file_name, ngram_file_type_t file_type, logmath_t *lmath);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_model_t* ngram_model_read(cmd_ln_t* config, sbyte* file_name, ngram_file_type_t file_type, logmath_t* lmath);

    //    // extern int ngram_model_write (ngram_model_t *model, const char *file_name, ngram_file_type_t format);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_model_write(ngram_model_t* model, sbyte* file_name, ngram_file_type_t format);

    //    // extern ngram_file_type_t ngram_file_name_to_type (const char *file_name);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_file_type_t ngram_file_name_to_type(sbyte* file_name);

    //    // extern ngram_file_type_t ngram_str_to_type (const char *str_name);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_file_type_t ngram_str_to_type(sbyte* str_name);

    //    // extern const char * ngram_type_to_str (int type);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* ngram_type_to_str(int type);

    //    // extern ngram_model_t * ngram_model_retain (ngram_model_t *model);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_model_t* ngram_model_retain(ngram_model_t* model);

    //    // extern int ngram_model_free (ngram_model_t *model);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_model_free(ngram_model_t* model);

    //    // extern int ngram_model_casefold (ngram_model_t *model, int kase);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_model_casefold(ngram_model_t* model, int kase);

    //    // extern int ngram_model_apply_weights (ngram_model_t *model, int lw, int wip);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_model_apply_weights(ngram_model_t* model, int lw, int wip);

    //    // extern int ngram_model_get_weights (ngram_model_t *model, int *out_log_wip);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_model_get_weights(ngram_model_t* model, int* out_log_wip);

    //    // extern int ngram_score (ngram_model_t *model, const char *word, ...);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_score(ngram_model_t* model, sbyte* word, IntPtr varArgs);

    //    // extern int ngram_tg_score (ngram_model_t *model, int w3, int w2, int w1, int *n_used);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_tg_score(ngram_model_t* model, int w3, int w2, int w1, int* n_used);

    //    // extern int ngram_bg_score (ngram_model_t *model, int w2, int w1, int *n_used);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_bg_score(ngram_model_t* model, int w2, int w1, int* n_used);

    //    // extern int ngram_ng_score (ngram_model_t *model, int wid, int *history, int n_hist, int *n_used);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_ng_score(ngram_model_t* model, int wid, int* history, int n_hist, int* n_used);

    //    // extern int ngram_probv (ngram_model_t *model, const char *word, ...);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_probv(ngram_model_t* model, sbyte* word, IntPtr varArgs);

    //    // extern int ngram_prob (ngram_model_t *model, const char *const *words, int n);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_prob(ngram_model_t* model, sbyte** words, int n);

    //    // extern int ngram_ng_prob (ngram_model_t *model, int wid, int *history, int n_hist, int *n_used);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_ng_prob(ngram_model_t* model, int wid, int* history, int n_hist, int* n_used);

    //    // extern int ngram_score_to_prob (ngram_model_t *model, int score);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_score_to_prob(ngram_model_t* model, int score);

    //    // extern int ngram_wid (ngram_model_t *model, const char *word);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_wid(ngram_model_t* model, sbyte* word);

    //    // extern const char * ngram_word (ngram_model_t *model, int wid);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* ngram_word(ngram_model_t* model, int wid);

    //    // extern int ngram_unknown_wid (ngram_model_t *model);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_unknown_wid(ngram_model_t* model);

    //    // extern int ngram_zero (ngram_model_t *model);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_zero(ngram_model_t* model);

    //    // extern int ngram_model_get_size (ngram_model_t *model);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_model_get_size(ngram_model_t* model);

    //    // extern ngram_iter_t * ngram_model_mgrams (ngram_model_t *model, int m);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_iter_t* ngram_model_mgrams(ngram_model_t* model, int m);

    //    // extern ngram_iter_t * ngram_iter (ngram_model_t *model, const char *word, ...);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_iter_t* ngram_iter(ngram_model_t* model, sbyte* word, IntPtr varArgs);

    //    // extern ngram_iter_t * ngram_ng_iter (ngram_model_t *model, int wid, int *history, int n_hist);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_iter_t* ngram_ng_iter(ngram_model_t* model, int wid, int* history, int n_hist);

    //    // extern ngram_iter_t * ngram_iter_successors (ngram_iter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_iter_t* ngram_iter_successors(ngram_iter_t* itor);

    //    // extern ngram_iter_t * ngram_iter_next (ngram_iter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_iter_t* ngram_iter_next(ngram_iter_t* itor);

    //    // extern void ngram_iter_free (ngram_iter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ngram_iter_free(ngram_iter_t* itor);

    //    // extern int ngram_model_add_word (ngram_model_t *model, const char *word, int weight);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_model_add_word(ngram_model_t* model, sbyte* word, int weight);

    //    // extern int ngram_model_read_classdef (ngram_model_t *model, const char *file_name);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_model_read_classdef(ngram_model_t* model, sbyte* file_name);

    //    // extern int ngram_model_add_class (ngram_model_t *model, const char *classname, int classweight, char **words, const int *weights, int n_words);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_model_add_class(ngram_model_t* model, sbyte* classname, int classweight, sbyte** words, int* weights, int n_words);

    //    // extern int ngram_model_add_class_word (ngram_model_t *model, const char *classname, const char *word, int weight);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_model_add_class_word(ngram_model_t* model, sbyte* classname, sbyte* word, int weight);

    //    // extern ngram_model_t * ngram_model_set_init (cmd_ln_t *config, ngram_model_t **models, char **names, const int *weights, int n_models);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_model_t* ngram_model_set_init(cmd_ln_t* config, ngram_model_t** models, sbyte** names, int* weights, int n_models);

    //    // extern ngram_model_t * ngram_model_set_read (cmd_ln_t *config, const char *lmctlfile, logmath_t *lmath);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_model_t* ngram_model_set_read(cmd_ln_t* config, sbyte* lmctlfile, logmath_t* lmath);

    //    // extern int ngram_model_set_count (ngram_model_t *set);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_model_set_count(ngram_model_t* set);

    //    // extern ngram_model_set_iter_t * ngram_model_set_iter (ngram_model_t *set);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_model_set_iter_t* ngram_model_set_iter(ngram_model_t* set);

    //    // extern ngram_model_set_iter_t * ngram_model_set_iter_next (ngram_model_set_iter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_model_set_iter_t* ngram_model_set_iter_next(ngram_model_set_iter_t* itor);

    //    // extern void ngram_model_set_iter_free (ngram_model_set_iter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ngram_model_set_iter_free(ngram_model_set_iter_t* itor);

    //    // extern ngram_model_t * ngram_model_set_iter_model (ngram_model_set_iter_t *itor, const char **lmname);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_model_t* ngram_model_set_iter_model(ngram_model_set_iter_t* itor, sbyte** lmname);

    //    // extern ngram_model_t * ngram_model_set_select (ngram_model_t *set, const char *name);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_model_t* ngram_model_set_select(ngram_model_t* set, sbyte* name);

    //    // extern ngram_model_t * ngram_model_set_lookup (ngram_model_t *set, const char *name);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_model_t* ngram_model_set_lookup(ngram_model_t* set, sbyte* name);

    //    // extern const char * ngram_model_set_current (ngram_model_t *set);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* ngram_model_set_current(ngram_model_t* set);

    //    // extern ngram_model_t * ngram_model_set_interp (ngram_model_t *set, const char **names, const int *weights);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_model_t* ngram_model_set_interp(ngram_model_t* set, sbyte** names, int* weights);

    //    // extern ngram_model_t * ngram_model_set_add (ngram_model_t *set, ngram_model_t *model, const char *name, int weight, int reuse_widmap);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_model_t* ngram_model_set_add(ngram_model_t* set, ngram_model_t* model, sbyte* name, int weight, int reuse_widmap);

    //    // extern ngram_model_t * ngram_model_set_remove (ngram_model_t *set, const char *name, int reuse_widmap);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_model_t* ngram_model_set_remove(ngram_model_t* set, sbyte* name, int reuse_widmap);

    //    // extern void ngram_model_set_map_words (ngram_model_t *set, const char **words, int n_words);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ngram_model_set_map_words(ngram_model_t* set, sbyte** words, int n_words);

    //    // extern int ngram_model_set_current_wid (ngram_model_t *set, int set_wid);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_model_set_current_wid(ngram_model_t* set, int set_wid);

    //    // extern int ngram_model_set_known_wid (ngram_model_t *set, int set_wid);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ngram_model_set_known_wid(ngram_model_t* set, int set_wid);

    //    // extern void ngram_model_flush (ngram_model_t *lm);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ngram_model_flush(ngram_model_t* lm);

    //    // extern FILE * fopen_comp (const char *file, const char *mode, int *ispipe);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe FILE* fopen_comp(sbyte* file, sbyte* mode, int* ispipe);

    //    // extern void fclose_comp (FILE *fp, int ispipe);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void fclose_comp(FILE* fp, int ispipe);

    //    // extern FILE * fopen_compchk (const char *file, int *ispipe);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe FILE* fopen_compchk(sbyte* file, int* ispipe);

    //    // extern FILE * _myfopen (const char *file, const char *mode, const char *pgm, int line);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe FILE* _myfopen(sbyte* file, sbyte* mode, sbyte* pgm, int line);

    //    // extern int fread_retry (void *pointer, int size, int num_items, FILE *stream);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int fread_retry(void* pointer, int size, int num_items, FILE* stream);

    //    // extern char * fread_line (FILE *stream, size_t *out_len);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* fread_line(FILE* stream, nuint* out_len);

    //    // extern lineiter_t * lineiter_start (FILE *fh);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe lineiter_t* lineiter_start(FILE* fh);

    //    // extern lineiter_t * lineiter_start_clean (FILE *fh);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe lineiter_t* lineiter_start_clean(FILE* fh);

    //    // extern lineiter_t * lineiter_next (lineiter_t *li);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe lineiter_t* lineiter_next(lineiter_t* li);

    //    // extern void lineiter_free (lineiter_t *li);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void lineiter_free(lineiter_t* li);

    //    // extern int lineiter_lineno (lineiter_t *li);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int lineiter_lineno(lineiter_t* li);

    //    // extern bit_encode_t * bit_encode_attach (FILE *outfh);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe bit_encode_t* bit_encode_attach(FILE* outfh);

    //    // extern bit_encode_t * bit_encode_retain (bit_encode_t *be);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe bit_encode_t* bit_encode_retain(bit_encode_t* be);

    //    // extern int bit_encode_free (bit_encode_t *be);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int bit_encode_free(bit_encode_t* be);

    //    // extern int bit_encode_write (bit_encode_t *be, const unsigned char *bits, int nbits);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int bit_encode_write(bit_encode_t* be, byte* bits, int nbits);

    //    // extern int bit_encode_write_cw (bit_encode_t *be, int codeword, int nbits);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int bit_encode_write_cw(bit_encode_t* be, int codeword, int nbits);

    //    // extern int bit_encode_flush (bit_encode_t *be);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int bit_encode_flush(bit_encode_t* be);

    //    // extern int stat_retry (const char *file, struct stat *statbuf);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int stat_retry(sbyte* file, stat* statbuf);

    //    // extern int stat_mtime (const char *file);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int stat_mtime(sbyte* file);

    //    // extern int build_directory (const char *path);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int build_directory(sbyte* path);

    //    // extern ps_lattice_t * ps_lattice_read (struct ps_decoder_s *ps, const char *file);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_lattice_t* ps_lattice_read(ps_decoder_s* ps, sbyte* file);

    //    // extern ps_lattice_t * ps_lattice_retain (ps_lattice_t *dag);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_lattice_t* ps_lattice_retain(ps_lattice_t* dag);

    //    // extern int ps_lattice_free (ps_lattice_t *dag);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_lattice_free(ps_lattice_t* dag);

    //    // extern int ps_lattice_write (ps_lattice_t *dag, const char *filename);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_lattice_write(ps_lattice_t* dag, sbyte* filename);

    //    // extern int ps_lattice_write_htk (ps_lattice_t *dag, const char *filename);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_lattice_write_htk(ps_lattice_t* dag, sbyte* filename);

    //    // extern logmath_t * ps_lattice_get_logmath (ps_lattice_t *dag);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe logmath_t* ps_lattice_get_logmath(ps_lattice_t* dag);

    //    // extern ps_latnode_iter_t * ps_latnode_iter (ps_lattice_t *dag);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_latnode_iter_t* ps_latnode_iter(ps_lattice_t* dag);

    //    // extern ps_latnode_iter_t * ps_latnode_iter_next (ps_latnode_iter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_latnode_iter_t* ps_latnode_iter_next(ps_latnode_iter_t* itor);

    //    // extern void ps_latnode_iter_free (ps_latnode_iter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ps_latnode_iter_free(ps_latnode_iter_t* itor);

    //    // extern ps_latnode_t * ps_latnode_iter_node (ps_latnode_iter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_latnode_t* ps_latnode_iter_node(ps_latnode_iter_t* itor);

    //    // extern int ps_latnode_times (ps_latnode_t *node, int *out_fef, int *out_lef);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_latnode_times(ps_latnode_t* node, int* out_fef, int* out_lef);

    //    // extern const char * ps_latnode_word (ps_lattice_t *dag, ps_latnode_t *node);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* ps_latnode_word(ps_lattice_t* dag, ps_latnode_t* node);

    //    // extern const char * ps_latnode_baseword (ps_lattice_t *dag, ps_latnode_t *node);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* ps_latnode_baseword(ps_lattice_t* dag, ps_latnode_t* node);

    //    // extern ps_latlink_iter_t * ps_latnode_exits (ps_latnode_t *node);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_latlink_iter_t* ps_latnode_exits(ps_latnode_t* node);

    //    // extern ps_latlink_iter_t * ps_latnode_entries (ps_latnode_t *node);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_latlink_iter_t* ps_latnode_entries(ps_latnode_t* node);

    //    // extern int ps_latnode_prob (ps_lattice_t *dag, ps_latnode_t *node, ps_latlink_t **out_link);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_latnode_prob(ps_lattice_t* dag, ps_latnode_t* node, ps_latlink_t** out_link);

    //    // extern ps_latlink_iter_t * ps_latlink_iter_next (ps_latlink_iter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_latlink_iter_t* ps_latlink_iter_next(ps_latlink_iter_t* itor);

    //    // extern void ps_latlink_iter_free (ps_latlink_iter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ps_latlink_iter_free(ps_latlink_iter_t* itor);

    //    // extern ps_latlink_t * ps_latlink_iter_link (ps_latlink_iter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_latlink_t* ps_latlink_iter_link(ps_latlink_iter_t* itor);

    //    // extern int ps_latlink_times (ps_latlink_t *link, int *out_sf);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_latlink_times(ps_latlink_t* link, int* out_sf);

    //    // extern ps_latnode_t * ps_latlink_nodes (ps_latlink_t *link, ps_latnode_t **out_src);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_latnode_t* ps_latlink_nodes(ps_latlink_t* link, ps_latnode_t** out_src);

    //    // extern const char * ps_latlink_word (ps_lattice_t *dag, ps_latlink_t *link);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* ps_latlink_word(ps_lattice_t* dag, ps_latlink_t* link);

    //    // extern const char * ps_latlink_baseword (ps_lattice_t *dag, ps_latlink_t *link);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* ps_latlink_baseword(ps_lattice_t* dag, ps_latlink_t* link);

    //    // extern ps_latlink_t * ps_latlink_pred (ps_latlink_t *link);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_latlink_t* ps_latlink_pred(ps_latlink_t* link);

    //    // extern int ps_latlink_prob (ps_lattice_t *dag, ps_latlink_t *link, int *out_ascr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_latlink_prob(ps_lattice_t* dag, ps_latlink_t* link, int* out_ascr);

    //    // extern void ps_lattice_link (ps_lattice_t *dag, ps_latnode_t *from, ps_latnode_t *to, int score, int ef);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ps_lattice_link(ps_lattice_t* dag, ps_latnode_t* from, ps_latnode_t* to, int score, int ef);

    //    // extern ps_latlink_t * ps_lattice_traverse_edges (ps_lattice_t *dag, ps_latnode_t *start, ps_latnode_t *end);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_latlink_t* ps_lattice_traverse_edges(ps_lattice_t* dag, ps_latnode_t* start, ps_latnode_t* end);

    //    // extern ps_latlink_t * ps_lattice_traverse_next (ps_lattice_t *dag, ps_latnode_t *end);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_latlink_t* ps_lattice_traverse_next(ps_lattice_t* dag, ps_latnode_t* end);

    //    // extern ps_latlink_t * ps_lattice_reverse_edges (ps_lattice_t *dag, ps_latnode_t *start, ps_latnode_t *end);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_latlink_t* ps_lattice_reverse_edges(ps_lattice_t* dag, ps_latnode_t* start, ps_latnode_t* end);

    //    // extern ps_latlink_t * ps_lattice_reverse_next (ps_lattice_t *dag, ps_latnode_t *start);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_latlink_t* ps_lattice_reverse_next(ps_lattice_t* dag, ps_latnode_t* start);

    //    // extern ps_latlink_t * ps_lattice_bestpath (ps_lattice_t *dag, ngram_model_t *lmset, int lwf, int ascale);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_latlink_t* ps_lattice_bestpath(ps_lattice_t* dag, ngram_model_t* lmset, int lwf, int ascale);

    //    // extern int ps_lattice_posterior (ps_lattice_t *dag, ngram_model_t *lmset, int ascale);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_lattice_posterior(ps_lattice_t* dag, ngram_model_t* lmset, int ascale);

    //    // extern int ps_lattice_posterior_prune (ps_lattice_t *dag, int beam);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_lattice_posterior_prune(ps_lattice_t* dag, int beam);

    //    // extern int ps_lattice_n_frames (ps_lattice_t *dag);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_lattice_n_frames(ps_lattice_t* dag);

    //    // extern ps_mllr_t * ps_mllr_read (const char *file);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_mllr_t* ps_mllr_read(sbyte* file);

    //    // extern ps_mllr_t * ps_mllr_retain (ps_mllr_t *mllr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_mllr_t* ps_mllr_retain(ps_mllr_t* mllr);

    //    // extern int ps_mllr_free (ps_mllr_t *mllr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_mllr_free(ps_mllr_t* mllr);

    //    // extern int ps_set_search (ps_decoder_t *ps, const char *name);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_set_search(ps_decoder_t* ps, sbyte* name);

    //    // extern const char * ps_get_search (ps_decoder_t *ps);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* ps_get_search(ps_decoder_t* ps);

    //    // extern int ps_unset_search (ps_decoder_t *ps, const char *name);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_unset_search(ps_decoder_t* ps, sbyte* name);

    //    // extern ps_search_iter_t * ps_search_iter (ps_decoder_t *ps);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_search_iter_t* ps_search_iter(ps_decoder_t* ps);

    //    // extern ps_search_iter_t * ps_search_iter_next (ps_search_iter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_search_iter_t* ps_search_iter_next(ps_search_iter_t* itor);

    //    // extern const char * ps_search_iter_val (ps_search_iter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* ps_search_iter_val(ps_search_iter_t* itor);

    //    // extern void ps_search_iter_free (ps_search_iter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ps_search_iter_free(ps_search_iter_t* itor);

    //    // extern const char * ps_search_iter_val (ps_search_iter_t *itor);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* ps_search_iter_val(ps_search_iter_t* itor);

    //    // extern ngram_model_t * ps_get_lm (ps_decoder_t *ps, const char *name);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ngram_model_t* ps_get_lm(ps_decoder_t* ps, sbyte* name);

    //    // extern int ps_set_lm (ps_decoder_t *ps, const char *name, ngram_model_t *lm);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_set_lm(ps_decoder_t* ps, sbyte* name, ngram_model_t* lm);

    //    // extern int ps_set_lm_file (ps_decoder_t *ps, const char *name, const char *path);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_set_lm_file(ps_decoder_t* ps, sbyte* name, sbyte* path);

    //    // extern fsg_model_t * ps_get_fsg (ps_decoder_t *ps, const char *name);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe fsg_model_t* ps_get_fsg(ps_decoder_t* ps, sbyte* name);

    //    // extern int ps_set_fsg (ps_decoder_t *ps, const char *name, fsg_model_t *fsg);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_set_fsg(ps_decoder_t* ps, sbyte* name, fsg_model_t* fsg);

    //    // extern int ps_set_jsgf_file (ps_decoder_t *ps, const char *name, const char *path);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_set_jsgf_file(ps_decoder_t* ps, sbyte* name, sbyte* path);

    //    // extern int ps_set_jsgf_string (ps_decoder_t *ps, const char *name, const char *jsgf_string);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_set_jsgf_string(ps_decoder_t* ps, sbyte* name, sbyte* jsgf_string);

    //    // extern const char * ps_get_kws (ps_decoder_t *ps, const char *name);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* ps_get_kws(ps_decoder_t* ps, sbyte* name);

    //    // extern int ps_set_kws (ps_decoder_t *ps, const char *name, const char *keyfile);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_set_kws(ps_decoder_t* ps, sbyte* name, sbyte* keyfile);

    //    // extern int ps_set_keyphrase (ps_decoder_t *ps, const char *name, const char *keyphrase);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_set_keyphrase(ps_decoder_t* ps, sbyte* name, sbyte* keyphrase);

    //    // extern int ps_set_allphone (ps_decoder_t *ps, const char *name, ngram_model_t *lm);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_set_allphone(ps_decoder_t* ps, sbyte* name, ngram_model_t* lm);

    //    // extern int ps_set_allphone_file (ps_decoder_t *ps, const char *name, const char *path);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_set_allphone_file(ps_decoder_t* ps, sbyte* name, sbyte* path);

    //    // extern void ps_default_search_args (cmd_ln_t *);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ps_default_search_args(cmd_ln_t*);

    //    // extern ps_decoder_t * ps_init (cmd_ln_t *config);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_decoder_t* ps_init(cmd_ln_t* config);

    //    // extern int ps_reinit (ps_decoder_t *ps, cmd_ln_t *config);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_reinit(ps_decoder_t* ps, cmd_ln_t* config);

    //    // extern const arg_t * ps_args ();
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe arg_t* ps_args();

    //    // extern ps_decoder_t * ps_retain (ps_decoder_t *ps);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_decoder_t* ps_retain(ps_decoder_t* ps);

    //    // extern int ps_free (ps_decoder_t *ps);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_free(ps_decoder_t* ps);

    //    // extern cmd_ln_t * ps_get_config (ps_decoder_t *ps);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe cmd_ln_t* ps_get_config(ps_decoder_t* ps);

    //    // extern logmath_t * ps_get_logmath (ps_decoder_t *ps);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe logmath_t* ps_get_logmath(ps_decoder_t* ps);

    //    // extern fe_t * ps_get_fe (ps_decoder_t *ps);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe fe_t* ps_get_fe(ps_decoder_t* ps);

    //    // extern feat_t * ps_get_feat (ps_decoder_t *ps);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe feat_t* ps_get_feat(ps_decoder_t* ps);

    //    // extern ps_mllr_t * ps_update_mllr (ps_decoder_t *ps, ps_mllr_t *mllr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_mllr_t* ps_update_mllr(ps_decoder_t* ps, ps_mllr_t* mllr);

    //    // extern int ps_load_dict (ps_decoder_t *ps, const char *dictfile, const char *fdictfile, const char *format);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_load_dict(ps_decoder_t* ps, sbyte* dictfile, sbyte* fdictfile, sbyte* format);

    //    // extern int ps_save_dict (ps_decoder_t *ps, const char *dictfile, const char *format);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_save_dict(ps_decoder_t* ps, sbyte* dictfile, sbyte* format);

    //    // extern int ps_add_word (ps_decoder_t *ps, const char *word, const char *phones, int update);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_add_word(ps_decoder_t* ps, sbyte* word, sbyte* phones, int update);

    //    // extern char * ps_lookup_word (ps_decoder_t *ps, const char *word);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* ps_lookup_word(ps_decoder_t* ps, sbyte* word);

    //    // extern long ps_decode_raw (ps_decoder_t *ps, FILE *rawfh, long maxsamps);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe nint ps_decode_raw(ps_decoder_t* ps, FILE* rawfh, nint maxsamps);

    //    // extern int ps_decode_senscr (ps_decoder_t *ps, FILE *senfh);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_decode_senscr(ps_decoder_t* ps, FILE* senfh);

    //    // extern int ps_start_stream (ps_decoder_t *ps);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_start_stream(ps_decoder_t* ps);

    //    // extern int ps_start_utt (ps_decoder_t *ps);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_start_utt(ps_decoder_t* ps);

    //    // extern int ps_process_raw (ps_decoder_t *ps, int);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_process_raw(ps_decoder_t* ps, int);

    //    // extern int ps_process_cep (ps_decoder_t *ps, mfcc_t **data, int n_frames, int no_search, int full_utt);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_process_cep(ps_decoder_t* ps, int** data, int n_frames, int no_search, int full_utt);

    //    // extern int ps_get_n_frames (ps_decoder_t *ps);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_get_n_frames(ps_decoder_t* ps);

    //    // extern int ps_end_utt (ps_decoder_t *ps);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_end_utt(ps_decoder_t* ps);

    //    // extern const char * ps_get_hyp (ps_decoder_t *ps, int *out_best_score);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* ps_get_hyp(ps_decoder_t* ps, int* out_best_score);

    //    // extern int ps_get_prob (ps_decoder_t *ps);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_get_prob(ps_decoder_t* ps);

    //    // extern ps_lattice_t * ps_get_lattice (ps_decoder_t *ps);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_lattice_t* ps_get_lattice(ps_decoder_t* ps);

    //    // extern ps_seg_t * ps_seg_iter (ps_decoder_t *ps);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_seg_t* ps_seg_iter(ps_decoder_t* ps);

    //    // extern ps_seg_t * ps_seg_next (ps_seg_t *seg);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_seg_t* ps_seg_next(ps_seg_t* seg);

    //    // extern const char * ps_seg_word (ps_seg_t *seg);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* ps_seg_word(ps_seg_t* seg);

    //    // extern void ps_seg_frames (ps_seg_t *seg, int *out_sf, int *out_ef);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ps_seg_frames(ps_seg_t* seg, int* out_sf, int* out_ef);

    //    // extern int ps_seg_prob (ps_seg_t *seg, int *out_ascr, int *out_lscr, int *out_lback);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_seg_prob(ps_seg_t* seg, int* out_ascr, int* out_lscr, int* out_lback);

    //    // extern void ps_seg_free (ps_seg_t *seg);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ps_seg_free(ps_seg_t* seg);

    //    // extern ps_nbest_t * ps_nbest (ps_decoder_t *ps);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_nbest_t* ps_nbest(ps_decoder_t* ps);

    //    // extern ps_nbest_t * ps_nbest_next (ps_nbest_t *nbest);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_nbest_t* ps_nbest_next(ps_nbest_t* nbest);

    //    // extern const char * ps_nbest_hyp (ps_nbest_t *nbest, int *out_score);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* ps_nbest_hyp(ps_nbest_t* nbest, int* out_score);

    //    // extern ps_seg_t * ps_nbest_seg (ps_nbest_t *nbest);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe ps_seg_t* ps_nbest_seg(ps_nbest_t* nbest);

    //    // extern void ps_nbest_free (ps_nbest_t *nbest);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ps_nbest_free(ps_nbest_t* nbest);

    //    // extern void ps_get_utt_time (ps_decoder_t *ps, double *out_nspeech, double *out_ncpu, double *out_nwall);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ps_get_utt_time(ps_decoder_t* ps, double* out_nspeech, double* out_ncpu, double* out_nwall);

    //    // extern void ps_get_all_time (ps_decoder_t *ps, double *out_nspeech, double *out_ncpu, double *out_nwall);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ps_get_all_time(ps_decoder_t* ps, double* out_nspeech, double* out_ncpu, double* out_nwall);

    //    // extern int ps_get_in_speech (ps_decoder_t *ps);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int ps_get_in_speech(ps_decoder_t* ps);

    //    // extern void ps_set_rawdata_size (ps_decoder_t *ps, int size);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ps_set_rawdata_size(ps_decoder_t* ps, int size);

    //    // extern void ps_get_rawdata (ps_decoder_t *ps, int **buffer, int *size);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ps_get_rawdata(ps_decoder_t* ps, int** buffer, int* size);

    //    // extern priority_queue_t * priority_queue_create (size_t len, int (* compare)(const void *, const void *));
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe priority_queue_t* priority_queue_create(nuint len, Func<void*, void*, int>* compare);

    //    // extern void * priority_queue_poll (priority_queue_t *queue);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void* priority_queue_poll(priority_queue_t* queue);

    //    // extern void priority_queue_add (priority_queue_t *queue, void *element);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void priority_queue_add(priority_queue_t* queue, void* element);

    //    // extern size_t priority_queue_size (priority_queue_t *queue);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe nuint priority_queue_size(priority_queue_t* queue);

    //    // extern void priority_queue_free (priority_queue_t *queue, void (* free_ptr)(void *));
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void priority_queue_free(priority_queue_t* queue, Action<void*>* free_ptr);

    //    // extern pctr_t * pctr_new (char *name);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe pctr_t* pctr_new(sbyte* name);

    //    // extern void pctr_reset (pctr_t *ctr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void pctr_reset(pctr_t* ctr);

    //    // extern void pctr_print (FILE *fp, pctr_t *ctr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void pctr_print(FILE* fp, pctr_t* ctr);

    //    // extern void pctr_increment (pctr_t *ctr, int inc);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void pctr_increment(pctr_t* ctr, int inc);

    //    // extern void pctr_free (pctr_t *ctr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void pctr_free(pctr_t* ctr);

    //    // extern void ptmr_start (ptmr_t *tmr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ptmr_start(ptmr_t* tmr);

    //    // extern void ptmr_stop (ptmr_t *tmr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ptmr_stop(ptmr_t* tmr);

    //    // extern void ptmr_reset (ptmr_t *tmr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ptmr_reset(ptmr_t* tmr);

    //    // extern void ptmr_init (ptmr_t *tmr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ptmr_init(ptmr_t* tmr);

    //    // extern void ptmr_reset_all (ptmr_t *tmr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ptmr_reset_all(ptmr_t* tmr);

    //    // extern void ptmr_print_all (FILE *fp, ptmr_t *tmr, float64 norm);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void ptmr_print_all(FILE* fp, ptmr_t* tmr, double norm);

    //    // extern int host_pclk (int dummy);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern int host_pclk(int dummy);

    //    // extern int host_endian ();
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern int host_endian();

    //    // extern sbthread_t * sbthread_start (cmd_ln_t *config, sbthread_main func, void *arg);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbthread_t* sbthread_start(cmd_ln_t* config, sbthread_main* func, void* arg);

    //    // extern int sbthread_wait (sbthread_t *th);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int sbthread_wait(sbthread_t* th);

    //    // extern void sbthread_free (sbthread_t *th);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void sbthread_free(sbthread_t* th);

    //    // extern cmd_ln_t * sbthread_config (sbthread_t *th);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe cmd_ln_t* sbthread_config(sbthread_t* th);

    //    // extern void * sbthread_arg (sbthread_t *th);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void* sbthread_arg(sbthread_t* th);

    //    // extern sbmsgq_t * sbthread_msgq (sbthread_t *th);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbmsgq_t* sbthread_msgq(sbthread_t* th);

    //    // extern int sbthread_wait (sbthread_t *th);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int sbthread_wait(sbthread_t* th);

    //    // extern int sbthread_send (sbthread_t *th, size_t len, const void *data);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int sbthread_send(sbthread_t* th, nuint len, void* data);

    //    // extern sbmsgq_t * sbmsgq_init (size_t depth);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbmsgq_t* sbmsgq_init(nuint depth);

    //    // extern void sbmsgq_free (sbmsgq_t *q);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void sbmsgq_free(sbmsgq_t* q);

    //    // extern int sbmsgq_send (sbmsgq_t *q, size_t len, const void *data);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int sbmsgq_send(sbmsgq_t* q, nuint len, void* data);

    //    // extern void * sbmsgq_wait (sbmsgq_t *q, size_t *out_len, int sec, int nsec);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void* sbmsgq_wait(sbmsgq_t* q, nuint* out_len, int sec, int nsec);

    //    // extern sbmtx_t * sbmtx_init ();
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbmtx_t* sbmtx_init();

    //    // extern int sbmtx_trylock (sbmtx_t *mtx);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int sbmtx_trylock(sbmtx_t* mtx);

    //    // extern int sbmtx_lock (sbmtx_t *mtx);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int sbmtx_lock(sbmtx_t* mtx);

    //    // extern int sbmtx_unlock (sbmtx_t *mtx);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int sbmtx_unlock(sbmtx_t* mtx);

    //    // extern void sbmtx_free (sbmtx_t *mtx);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void sbmtx_free(sbmtx_t* mtx);

    //    // extern sbevent_t * sbevent_init ();
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbevent_t* sbevent_init();

    //    // extern void sbevent_free (sbevent_t *evt);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void sbevent_free(sbevent_t* evt);

    //    // extern int sbevent_signal (sbevent_t *evt);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int sbevent_signal(sbevent_t* evt);

    //    // extern int sbevent_wait (sbevent_t *evt, int sec, int nsec);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int sbevent_wait(sbevent_t* evt, int sec, int nsec);

    //    // extern char * string_join (const char *base, ...);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* string_join(sbyte* @base, IntPtr varArgs);

    //    // extern char * string_trim (char *string, enum string_edge_e which);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe sbyte* string_trim(sbyte* @string, string_edge_e which);

    //    // extern double atof_c (const char *str);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe double atof_c(sbyte* str);

    //    // extern int str2words (char *line, char **wptr, int n_wptr);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int str2words(sbyte* line, sbyte** wptr, int n_wptr);

    //    // extern int nextword (char *line, const char *delim, char **word, char *delimfound);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int nextword(sbyte* line, sbyte* delim, sbyte** word, sbyte* delimfound);

    //    // extern yin_t * yin_init (int frame_size, float search_threshold, float search_range, int smooth_window);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe yin_t* yin_init(int frame_size, float search_threshold, float search_range, int smooth_window);

    //    // extern void yin_free (yin_t *pe);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void yin_free(yin_t* pe);

    //    // extern void yin_start (yin_t *pe);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void yin_start(yin_t* pe);

    //    // extern void yin_end (yin_t *pe);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void yin_end(yin_t* pe);

    //    // extern void yin_write (yin_t *pe, int);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe void yin_write(yin_t* pe, int);

    //    // extern int yin_read (yin_t *pe, uint16 *out_period, uint16 *out_bestdiff);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern unsafe int yin_read(yin_t* pe, ushort* out_period, ushort* out_bestdiff);
    //}

    [StructLayout(LayoutKind.Sequential)]
    public struct complex
    {
        public float r;

        public float i;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct doublecomplex
    {
        public double r;

        public double i;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct cilist
    {
        public int cierr;

        public int ciunit;

        public int ciend;

        public unsafe sbyte* cifmt;

        public int cirec;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct icilist
    {
        public int icierr;

        public unsafe sbyte* iciunit;

        public int iciend;

        public unsafe sbyte* icifmt;

        public int icirlen;

        public int icirnum;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct olist
    {
        public int oerr;

        public int ounit;

        public unsafe sbyte* ofnm;

        public int ofnmlen;

        public unsafe sbyte* osta;

        public unsafe sbyte* oacc;

        public unsafe sbyte* ofm;

        public int orl;

        public unsafe sbyte* oblnk;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct cllist
    {
        public int cerr;

        public int cunit;

        public unsafe sbyte* csta;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct alist
    {
        public int aerr;

        public int aunit;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct inlist
    {
        public int inerr;

        public int inunit;

        public unsafe sbyte* infile;

        public int infilen;

        public unsafe int* inex;

        public unsafe int* inopen;

        public unsafe int* innum;

        public unsafe int* innamed;

        public unsafe sbyte* inname;

        public int innamlen;

        public unsafe sbyte* inacc;

        public int inacclen;

        public unsafe sbyte* inseq;

        public int inseqlen;

        public unsafe sbyte* indir;

        public int indirlen;

        public unsafe sbyte* infmt;

        public int infmtlen;

        public unsafe sbyte* inform;

        public int informlen;

        public unsafe sbyte* inunf;

        public int inunflen;

        public unsafe int* inrecl;

        public unsafe int* innrec;

        public unsafe sbyte* inblank;

        public int inblanklen;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Multitype
    {
        [FieldOffset(0)]
        public short h;

        [FieldOffset(0)]
        public int i;

        [FieldOffset(0)]
        public float r;

        [FieldOffset(0)]
        public double d;

        [FieldOffset(0)]
        public complex c;

        [FieldOffset(0)]
        public doublecomplex z;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Vardesc
    {
        public unsafe sbyte* name;

        public unsafe sbyte* addr;

        public unsafe int* dims;

        public int type;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Namelist
    {
        public unsafe sbyte* name;

        public unsafe Vardesc** vars;

        public int nvars;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct anytype_t
    {
        [FieldOffset(0)]
        public unsafe void* ptr;

        [FieldOffset(0)]
        public nint i;

        [FieldOffset(0)]
        public nuint ui;

        [FieldOffset(0)]
        public double fl;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct arg_t
    {
        public unsafe sbyte* name;

        public int type;

        public unsafe sbyte* deflt;

        public unsafe sbyte* doc;
    }

    public enum cmn_type_t : uint
    {
        None = 0,
        Batch,
        Live
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct cmn_t
    {
        public unsafe int* cmn_mean;

        public unsafe int* cmn_var;

        public unsafe int* sum;

        public int nframe;

        public int veclen;
    }

    public enum err_lvl_t : uint
    {
        Debug,
        Info,
        Infocont,
        Warn,
        Error,
        Fatal,
        Max
    }

    public enum fe_error_e
    {
        Success = 0,
        OutputFileSuccess = 0,
        ControlFileError = -1,
        StartError = -2,
        UnknownSingleOrBatch = -3,
        InputFileOpenError = -4,
        InputFileReadError = -5,
        MemAllocError = -6,
        OutputFileWriteError = -7,
        OutputFileOpenError = -8,
        ZeroEnergyError = -9,
        InvalidParamError = -10
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct feat_t
    {
        public int refcount;

        public unsafe sbyte* name;

        public int cepsize;

        public int n_stream;

        public unsafe int* stream_len;

        public int window_size;

        public int n_sv;

        public unsafe int* sv_len;

        public unsafe int** subvecs;

        public unsafe int* sv_buf;

        public int sv_dim;

        public cmn_type_t cmn;

        public int varnorm;

        public agc_type_t agc;

        public unsafe Action<feat_s*, int**, int**>* compute_feat;

        public unsafe cmn_t* cmn_struct;

        public unsafe agc_t* agc_struct;

        public unsafe int** cepbuf;

        public unsafe int** tmpcepbuf;

        public int bufpos;

        public int curpos;

        public unsafe int*** lda;

        public int n_lda;

        public int out_dim;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct fsg_link_t
    {
        public int from_state;

        public int to_state;

        public int logs2prob;

        public int wid;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct fsg_model_t
    {
        public int refcount;

        public unsafe sbyte* name;

        public int n_word;

        public int n_word_alloc;

        public unsafe sbyte** vocab;

        public unsafe int* silwords;

        public unsafe int* altwords;

        public unsafe int* lmath;

        public int n_state;

        public int start_state;

        public int final_state;

        public int lw;

        public unsafe trans_list_t* trans;

        public unsafe int* link_alloc;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct gnode_t
    {
        public anytype_t data;

        public unsafe gnode_s* next;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct hash_entry_t
    {
        public unsafe sbyte* key;

        public nuint len;

        public unsafe void* val;

        public unsafe hash_entry_s* next;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct hash_table_t
    {
        public unsafe hash_entry_t* table;

        public int size;

        public int inuse;

        public int nocase;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct jsgf_rule_iter_t
    {
        public unsafe hash_table_t* ht;

        public unsafe hash_entry_t* ent;

        public nuint idx;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct logadd_s
    {
        public unsafe void* table;

        public int table_size;

        public int width;

        public sbyte shift;
    }

    public enum ngram_file_type_t
    {
        Invalid = -1,
        Auto,
        Arpa,
        Bin
    }

    public enum ngram_case_t : uint
    {
        Upper,
        Lower
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct lineiter_t
    {
        public unsafe sbyte* buf;

        public unsafe FILE* fh;

        public int bsiz;

        public int len;

        public int clean;

        public int lineno;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct pctr_t
    {
        public unsafe sbyte* name;

        public int count;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ptmr_t
    {
        public unsafe sbyte* name;

        public double t_cpu;

        public double t_elapsed;

        public double t_tot_cpu;

        public double t_tot_elapsed;

        public double start_cpu;

        public double start_elapsed;
    }

    public enum string_edge_e : uint
    {
        Start,
        End,
        Both
    }
}
