/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        "./wwwroot/**/*.{html,js,razor,cshtml}",
        "./**/Views/**/*.{cshtml,razor}"
    ],
    theme: {
        colors: {
            'primary': 'var(--p)',
            'primary-dark': 'var(--pa)',
            'secondary': 'var(--s)',
            'secondary-dark': 'var(--sa)',
            'accent': 'var(--a)',
            'accent-dark': 'var(--aa)',
            'extralight': 'var(--xl)',
            'light': 'var(--l)',
            'neutral': 'var(--n)',
            'dark': 'var(--bg)',
            'success': 'var(--success)',
            'error': 'var(--error)',
            'info': 'var(--info)',
            'warning': 'var(--warning)',
        },
    },
    plugins: [
    ],
}

